﻿using System;
using System.Drawing;
using CNCMaps.Engine.Map;
using CNCMaps.FileFormats.FileFormats;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace CNCMaps.Engine.Rendering {
	public class VoxelRenderer : IDisposable {
		private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
		GraphicsContext _ctx;
		GameWindow _gw;
		bool _canRender;
		bool _isInit;

		// color contributors; the standard voxels.vpl already adds a lot of ambient,
		// that's why these seem high
		private static readonly Vector3 Diffuse = new Vector3(1.3f);
		private static readonly Vector3 Ambient = new Vector3(0.8f);

		DrawingSurface _surface;
		// VplFile _vplFile;

		public void Initialize() {
			Logger.Info("Initializing voxel renderer");
			_isInit = true;

			_surface = new DrawingSurface(400, 400, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			if (!CreateContext()) {
				Logger.Error("No graphics context could not be initialized, voxel rendering will be unavailable");
				return;
			}

			Logger.Debug("GL context created");
			try {
				Logger.Debug("GL functions loaded");

				GL.Enable(EnableCap.DepthTest);
				GL.Enable(EnableCap.ColorMaterial);

				//_vplFile = VFS.Open<VplFile>("voxels.vpl"); 
				_canRender = SetupFramebuffer();
			}

			catch (Exception exc) {
				Logger.Error("Voxel rendering will not be available because an exception occurred while initializing OpenGL: {0}", exc.ToString());
			}
		}

		private bool CreateContext() {
			// logger.Debug("Creating graphics context, trying {0} first", Program.Settings.PreferOSMesa ? "OSMesa" : "Window Manager");

			//if (Program.Settings.PreferOSMesa)
			//	return CreateMesaContext() || CreateGameWindow();
			//else
			return CreateGameWindow() || CreateMesaContext();
		}

		private bool CreateGameWindow() {
			try {
				_gw = new GameWindow(_surface.Width, _surface.Height, GraphicsMode.Default, "", GameWindowFlags.Default);
				return true;
			}
			catch {
				Logger.Warn("GameWindow could not be created.");
				return false;
			}
		}

		private bool CreateMesaContext() {
			try {
				_ctx = GraphicsContext.CreateMesaContext();
				long ctxPtr = long.Parse(_ctx.ToString()); // cannot access private .Context
				if (ctxPtr != 0) {
					_ctx.MakeCurrent(new OpenTK.Platform.Mesa.BitmapWindowInfo(_surface.BitmapData));
					if (!_ctx.IsCurrent) {
						Logger.Warn("Could not make context current");
						throw new InvalidOperationException("Mesa context could not be made current");
					}
				}
				Logger.Info("Successfully acquired Mesa context");
				return true;
			}
			catch {
				Logger.Warn("Mesa context could not be created");
				return false;
			}
		}

		public void Dispose() {
			_surface.Dispose();
			if (_ctx != null) _ctx.Dispose();
			if (_gw != null) _gw.Dispose();
		}

		public DrawingSurface Render(VxlFile vxl, HvaFile hva, GameObject obj, DrawProperties props) {
			if (!_isInit) Initialize();
			if (!_canRender) {
				Logger.Warn("Not rendering {0} because no OpenGL context could be obtained", vxl.FileName);
				return null;
			}

			Logger.Debug("Rendering voxel {0}", vxl.FileName);
			vxl.Initialize();
			hva.Initialize();

			GL.Viewport(0, 0, _surface.BitmapData.Width, _surface.BitmapData.Height);
			GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);

			// RA2 uses dimetric projection with camera elevated 30° off the ground
			GL.MatrixMode(MatrixMode.Projection);
			var persp = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(30), _surface.BitmapData.Width / (float)_surface.BitmapData.Height, 1, _surface.BitmapData.Height);
			GL.LoadMatrix(ref persp);

			GL.MatrixMode(MatrixMode.Modelview);

#if DEBUG
			/*
			GL.PushMatrix();
			GL.LineWidth(4);
			GL.Color3(Color.Red);
			GL.Begin(BeginMode.Lines);
			GL.Vertex3(-100, 0, 0);
			GL.Vertex3(100, 0, 0);
			GL.End();
			GL.Color3(Color.Green);
			GL.Begin(BeginMode.Lines);
			GL.Vertex3(0, -100, 0);
			GL.Vertex3(0, 100, 0);
			GL.End();
			GL.Color3(Color.White);
			GL.Begin(BeginMode.Lines);
			GL.Vertex3(0, 0, -100);
			GL.Vertex3(0, 0, 100);
			GL.End();
			GL.PopMatrix();*/
#endif

			var lookat = Matrix4.LookAt(0, 0, -10, 0, 0, 0, 0, 1, 0);
			GL.LoadMatrix(ref lookat);

			GL.Translate(0, 0, 10);
			float direction = (obj is OwnableObject) ? (obj as OwnableObject).Direction : 0;
			float objectRotation = 45f - direction / 256f * 360f; // convert game rotation to world degrees

			var world = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(60));
			world = Matrix4.CreateRotationY(MathHelper.DegreesToRadians(180)) * world; // this is how the game places voxels flat on the world
			world = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(objectRotation)) * world; // object facing
			world = Matrix4.Scale(0.028f, 0.028f, 0.028f) * world;

			// art.ini TurretOffset value positions some voxel parts over our x-axis
			world = Matrix4.CreateTranslation(0.18f * props.TurretVoxelOffset, 0, 0) * world;
			GL.MultMatrix(ref world);

			// direction of light vector given by pitch & yaw
			float pitch = MathHelper.DegreesToRadians(210);
			float yaw = MathHelper.DegreesToRadians(120);

			// helps to find good pitch/yaw
			/*var colors = new[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Black, Color.Purple, Color.SlateBlue, Color.DimGray, Color.White, Color.Teal, Color.Tan };
			for (int i = 0; i < 360; i += 30) {
				for (int j = 0; j < 360; j += 30) {
					GL.Color3(colors[i / 30]);
					var shadowTransform2 =
						Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(210))
						* Matrix4.CreateRotationY(MathHelper.DegreesToRadians(120));
					GL.LineWidth(2);
					GL.Begin(BeginMode.Lines);
					GL.Vertex3(0, 0, 0);
					GL.Vertex3(Vector3.Multiply(ExtractRotationVector(ToOpenGL(Matrix4.Invert(world * shadowTransform2))), 100f));
					GL.End();
				}
			}*/

			var shadowTransform = Matrix4.CreateRotationZ(pitch) * Matrix4.CreateRotationY(yaw);

			foreach (var section in vxl.Sections) {
				GL.PushMatrix();

				var frameRot = hva.LoadGLMatrix(section.Index);
				frameRot.M41 *= section.HVAMultiplier * section.ScaleX;
				frameRot.M42 *= section.HVAMultiplier * section.ScaleY;
				frameRot.M43 *= section.HVAMultiplier * section.ScaleZ;

				var frameTransl = Matrix4.CreateTranslation(section.MinBounds);
				var frame = frameTransl * frameRot;
				GL.MultMatrix(ref frame);

				// undo world transformations on light direction
				var lightDirection = ExtractRotationVector(ToOpenGL(Matrix4.Invert(world * frame * shadowTransform)));

				// draw line in direction light comes from
				/*GL.Color3(Color.Red);
				GL.LineWidth(4f);
				GL.Begin(BeginMode.Lines);
				GL.Vertex3(0, 0, 0);
				GL.Vertex3(Vector3.Multiply(lightDirection, 100f));
				GL.End();*/

				GL.Begin(BeginMode.Quads);
				for (uint x = 0; x != section.SizeX; x++) {
					for (uint y = 0; y != section.SizeY; y++) {
						foreach (VxlFile.Voxel vx in section.Spans[x, y].Voxels) {
							Color color = obj.Palette.Colors[vx.ColorIndex];
							Vector3 normal = section.GetNormal(vx.NormalIndex);
							// shader function taken from https://github.com/OpenRA/OpenRA/blob/bleed/cg/vxl.fx
							// thanks to pchote for a LOT of help getting it right
							Vector3 colorMult = Vector3.Add(Ambient, Diffuse * Math.Max(Vector3.Dot(normal, lightDirection), 0f));
							GL.Color3(
								(byte)Math.Min(255, color.R * colorMult.X),
								(byte)Math.Min(255, color.G * colorMult.Y),
								(byte)Math.Min(255, color.B * colorMult.Z));

							Vector3 vxlPos = Vector3.Multiply(new Vector3(x, y, vx.Z), section.Scale);
							RenderVoxel(vxlPos);

							/* draw line in normal direction
							if (r.Next(100) == 4) {
								float m = Math.Max(Vector3.Dot(normal, lightDirection), 0f);
								GL.Color3(m, m, m);
								GL.LineWidth(1);
								GL.Begin(BeginMode.Lines);
								GL.Vertex3(new Vector3(x, y, vx.Z));
								GL.Vertex3(new Vector3(x, y, vx.Z) + Vector3.Multiply(normal, 100f));
								GL.End();
							}*/

						}
					}
				}
				GL.End();
				GL.PopMatrix();
			}

			// read pixels back to surface
			GL.ReadPixels(0, 0, _surface.BitmapData.Width, _surface.BitmapData.Height, PixelFormat.Bgra, PixelType.UnsignedByte, _surface.BitmapData.Scan0);
			return _surface;
		}

		public static Rectangle GetBounds(GameObject obj, VxlFile vxl, HvaFile hva, DrawProperties props) {
			vxl.Initialize();
			hva.Initialize();

			float direction = (obj is OwnableObject) ? (obj as OwnableObject).Direction : 0;
			float objectRotation = 45f - direction / 256f * 360f; // convert game rotation to world degrees

			var world = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(60));
			world = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(objectRotation)) * world; // object facing
			world = Matrix4.Scale(0.25f, 0.25f, 0.25f) * world;

			// art.ini TurretOffset value positions some voxel parts over our x-axis
			world = Matrix4.CreateTranslation(0.18f * props.TurretVoxelOffset, 0, 0) * world;
			var camera = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(30), 1f, 1, 100);
			world = world * camera;

			Rectangle ret = Rectangle.Empty;
			foreach (var section in vxl.Sections) {
				var frameRot = hva.LoadGLMatrix(section.Index);
				frameRot.M41 *= section.HVAMultiplier * section.ScaleX;
				frameRot.M42 *= section.HVAMultiplier * section.ScaleY;
				frameRot.M43 *= section.HVAMultiplier * section.ScaleZ;

				var frameTransl = Matrix4.CreateTranslation(section.MinBounds);
				var frame = frameTransl * frameRot * world;

				// floor rect of the bounding box
				Vector3 floorTopLeft = new Vector3(0, 0, 0);
				Vector3 floorTopRight = new Vector3(section.SpanX, 0, 0);
				Vector3 floorBottomRight = new Vector3(section.SpanX, section.SpanY, 0);
				Vector3 floorBottomLeft = new Vector3(0, section.SpanY, 0);

				// ceil rect of the bounding box
				Vector3 ceilTopLeft = new Vector3(0, 0, section.SpanZ);
				Vector3 ceilTopRight = new Vector3(section.SpanX, 0, section.SpanZ);
				Vector3 ceilBottomRight = new Vector3(section.SpanX, section.SpanY, section.SpanZ);
				Vector3 ceilBottomLeft = new Vector3(0, section.SpanY, section.SpanZ);

				// apply transformations
				floorTopLeft = Vector3.Transform(floorTopLeft, frame);
				floorTopRight = Vector3.Transform(floorTopRight, frame);
				floorBottomRight = Vector3.Transform(floorBottomRight, frame);
				floorBottomLeft = Vector3.Transform(floorBottomLeft, frame);

				ceilTopLeft = Vector3.Transform(ceilTopLeft, frame);
				ceilTopRight = Vector3.Transform(ceilTopRight, frame);
				ceilBottomRight = Vector3.Transform(ceilBottomRight, frame);
				ceilBottomLeft = Vector3.Transform(ceilBottomLeft, frame);

				int FminX = (int)Math.Floor(Math.Min(Math.Min(Math.Min(floorTopLeft.X, floorTopRight.X), floorBottomRight.X), floorBottomLeft.X));
				int FmaxX = (int)Math.Ceiling(Math.Max(Math.Max(Math.Max(floorTopLeft.X, floorTopRight.X), floorBottomRight.X), floorBottomLeft.X));
				int FminY = (int)Math.Floor(Math.Min(Math.Min(Math.Min(floorTopLeft.Y, floorTopRight.Y), floorBottomRight.Y), floorBottomLeft.Y));
				int FmaxY = (int)Math.Ceiling(Math.Max(Math.Max(Math.Max(floorTopLeft.Y, floorTopRight.Y), floorBottomRight.Y), floorBottomLeft.Y));

				int TminX = (int)Math.Floor(Math.Min(Math.Min(Math.Min(ceilTopLeft.X, ceilTopRight.X), ceilBottomRight.X), ceilBottomLeft.X));
				int TmaxX = (int)Math.Ceiling(Math.Max(Math.Max(Math.Max(ceilTopLeft.X, ceilTopRight.X), ceilBottomRight.X), ceilBottomLeft.X));
				int TminY = (int)Math.Floor(Math.Min(Math.Min(Math.Min(ceilTopLeft.Y, ceilTopRight.Y), ceilBottomRight.Y), ceilBottomLeft.Y));
				int TmaxY = (int)Math.Ceiling(Math.Max(Math.Max(Math.Max(ceilTopLeft.Y, ceilTopRight.Y), ceilBottomRight.Y), ceilBottomLeft.Y));

				int minX = Math.Min(FminX, TminX);
				int maxX = Math.Max(FmaxX, TmaxX);
				int minY = Math.Min(FminY, TminY);
				int maxY = Math.Max(FmaxY, TmaxY);

				ret = Rectangle.Union(ret, Rectangle.FromLTRB(minX, minY, maxX, maxY));
			}

			// return new Rectangle(-ret.Width / 2, -ret.Height / 2, ret.Width, ret.Height);
			return ret;
		}

		bool SetupFramebuffer() {
			int fbo;
			try {
				GL.Ext.GenFramebuffers(1, out fbo);
				GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, fbo);
				GL.DrawBuffer(DrawBufferMode.ColorAttachment0);
				GL.ReadBuffer(ReadBufferMode.ColorAttachment0);
			}
			catch {
				Logger.Error("Failed to initialize framebuffers. Voxels will not be rendered.");
				return false;
			}
			int depthbuffer;
			GL.Ext.GenRenderbuffers(1, out depthbuffer);
			GL.Ext.BindRenderbuffer(RenderbufferTarget.RenderbufferExt, depthbuffer);
			GL.Ext.RenderbufferStorage(RenderbufferTarget.RenderbufferExt, RenderbufferStorage.DepthComponent32, _surface.BitmapData.Width, _surface.BitmapData.Height);
			GL.Ext.FramebufferRenderbuffer(FramebufferTarget.FramebufferExt, FramebufferAttachment.DepthAttachmentExt, RenderbufferTarget.RenderbufferExt, depthbuffer);

			int rgb_rb;
			GL.Ext.GenRenderbuffers(1, out rgb_rb);
			GL.Ext.BindRenderbuffer(RenderbufferTarget.RenderbufferExt, rgb_rb);
			GL.Ext.RenderbufferStorage(RenderbufferTarget.RenderbufferExt, RenderbufferStorage.Rgba8, _surface.BitmapData.Width, _surface.BitmapData.Height);
			GL.Ext.FramebufferRenderbuffer(FramebufferTarget.FramebufferExt, FramebufferAttachment.ColorAttachment0Ext, RenderbufferTarget.RenderbufferExt, rgb_rb);

			return GL.CheckFramebufferStatus(FramebufferTarget.FramebufferExt) == FramebufferErrorCode.FramebufferCompleteExt;
		}

		static readonly float[] zeroVector = { 0, 0, 0, 1 };
		static readonly float[] zVector = { 0, 0, 1, 1 };
		static Vector3 ExtractRotationVector(float[] mtx) {
			var tVec = MatrixVectorMultiply(mtx, zVector);
			var tOrigin = MatrixVectorMultiply(mtx, zeroVector);
			tVec[0] -= tOrigin[0] * tVec[3] / tOrigin[3];
			tVec[1] -= tOrigin[1] * tVec[3] / tOrigin[3];
			tVec[2] -= tOrigin[2] * tVec[3] / tOrigin[3];

			// Renormalize
			var w = (float)Math.Sqrt(tVec[0] * tVec[0] + tVec[1] * tVec[1] + tVec[2] * tVec[2]);
			tVec[0] /= w;
			tVec[1] /= w;
			tVec[2] /= w;
			tVec[3] = 1f;

			return new Vector3(tVec[0], tVec[1], tVec[2]);
		}

		static float[] ToOpenGL(Matrix4 source) {
			var destination = new float[16];
			destination[00] = source.Column0.X;
			destination[01] = source.Column1.X;
			destination[02] = source.Column2.X;
			destination[03] = source.Column3.X;
			destination[04] = source.Column0.Y;
			destination[05] = source.Column1.Y;
			destination[06] = source.Column2.Y;
			destination[07] = source.Column3.Y;
			destination[08] = source.Column0.Z;
			destination[09] = source.Column1.Z;
			destination[10] = source.Column2.Z;
			destination[11] = source.Column3.Z;
			destination[12] = source.Column0.W;
			destination[13] = source.Column1.W;
			destination[14] = source.Column2.W;
			destination[15] = source.Column3.W;
			return destination;
		}

		static float[] MatrixVectorMultiply(float[] mtx, float[] vec) {
			var ret = new float[4];
			for (var j = 0; j < 4; j++) {
				ret[j] = 0;
				for (var k = 0; k < 4; k++)
					ret[j] += mtx[4 * k + j] * vec[k];
			}

			return ret;
		}

		public void RenderVoxel(Vector3 v) {
			float r = 0.5f;
			float left = v.X - r;
			float right = v.X + r;
			float fbase = v.Y - r;
			float top = v.Y + r;
			float front = v.Z - r;
			float back = v.Z + r;

			// Base
			GL.Vertex3(left, fbase, front);
			GL.Vertex3(right, fbase, front);
			GL.Vertex3(right, fbase, back);
			GL.Vertex3(left, fbase, back);

			// Back
			GL.Vertex3(left, fbase, back);
			GL.Vertex3(right, fbase, back);
			GL.Vertex3(right, top, back);
			GL.Vertex3(left, top, back);

			// Top
			GL.Vertex3(left, top, front);
			GL.Vertex3(right, top, front);
			GL.Vertex3(right, top, back);
			GL.Vertex3(left, top, back);

			// Right
			GL.Vertex3(right, fbase, front);
			GL.Vertex3(right, fbase, back);
			GL.Vertex3(right, top, back);
			GL.Vertex3(right, top, front);

			// Front
			GL.Vertex3(left, fbase, front);
			GL.Vertex3(right, fbase, front);
			GL.Vertex3(right, top, front);
			GL.Vertex3(left, top, front);

			// Left
			GL.Vertex3(left, fbase, front);
			GL.Vertex3(left, fbase, back);
			GL.Vertex3(left, top, back);
			GL.Vertex3(left, top, front);
		}

	}
}