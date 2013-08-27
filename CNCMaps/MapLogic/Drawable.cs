using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using CNCMaps.FileFormats;
using CNCMaps.Utility;
using CNCMaps.VirtualFileSystem;

namespace CNCMaps.MapLogic {
	class Drawable {
		static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		internal static readonly VoxelRenderer VoxelRenderer = new VoxelRenderer();

		public PaletteSettings PaletteType { get; set; }
		public LightingType LightingType { get; set; }
		public string CustomPaletteName { get; set; }

		internal IniFile.IniSection Rules { get; set; }
		internal IniFile.IniSection Art { get; set; }

		public Drawable(string name) {
			Name = name;
			Foundation = new Size(1, 1);
		}


		bool sorted;
		private List<Palette> firepalettes = new List<Palette>();
		private bool ignore_extra = false;
		void Sort() {
			// Starkku: Causes issues with the extended fire animations code.
			//_fires.Sort();
			_shps.Sort();
			_damagedShps.Sort();
			_voxels.Sort();
			sorted = true;
		}

		ShpFile _alphaImage;
		Point _globalOffset = new Point(0, 0);


		public string Name { get; private set; }
		public bool Overrides { get; set; }
		public Size Foundation { get; set; }
		public bool IsWall { get; set; }
		public bool IsVeins { get; set; }
		public int Direction { get; set; } // for voxels
		public int HeightOffset { get; set; }
		public int Frame { get; set; } // for shps
		public int TurretFrame { get; set; } // Starkku: Turret frame based on direction for turreted buildings.

		readonly List<DrawableFile<VxlFile>> _voxels = new List<DrawableFile<VxlFile>>();
		readonly List<HvaFile> _hvas = new List<HvaFile>();

		readonly List<DrawableFile<ShpFile>> _shps = new List<DrawableFile<ShpFile>>();
		readonly List<DrawableFile<ShpFile>> _fires = new List<DrawableFile<ShpFile>>();
		readonly List<DrawableFile<ShpFile>> _damagedShps = new List<DrawableFile<ShpFile>>();
		readonly DrawableFile<ShpFile> _turret;

		public virtual void Draw(GameObject obj, DrawingSurface ds) {
			logger.Trace("Drawing object {0} (type {1})", obj, obj.GetType());

			if (obj is UnitObject) Direction = (obj as UnitObject).Direction;
			else if (obj is StructureObject) Direction = (obj as StructureObject).Direction;

			if (!sorted) Sort();

			if (obj is DamageableObject && (obj as DamageableObject).Health < 128) {
				SetFrame(1); // Starkku: Make building display it's damaged artwork..
				foreach (var v in _damagedShps)
					DrawFile(obj, ds, v.File, v.Props);

				int i = 0;
				foreach (var v in _fires)
					DrawFile(obj, ds, v.File, v.Props, firepalettes[i++], false, true);
			}

			else {
				foreach (var v in _shps)
					if (v.Equals(_turret)) {
						setTurretFrame(Direction);
						DrawFile(obj, ds, v.File, v.Props, null, true);
					}
					else {
						DrawFile(obj, ds, v.File, v.Props);
					}
			}

			if (_alphaImage != null) {
				int dx = obj.Tile.Dx * TileWidth / 2;
				int dy = (obj.Tile.Dy - obj.Tile.Z) * TileHeight / 2;
				dx += _globalOffset.X;
				dy += _globalOffset.Y;
				dy += 15;
				_alphaImage.DrawAlpha(Direction, ds, dx, dy);
			}

			for (int i = 0; i < _voxels.Count; i++) {
				if (obj is UnitObject) Direction = (obj as UnitObject).Direction;
				else if (obj is StructureObject) Direction = (obj as StructureObject).Direction;

				// render voxel
				DrawingSurface vxl_ds = VoxelRenderer.Render(_voxels[i].File, _hvas[i], -(double)Direction / 256.0 * 360 + 45, obj.Palette);
				if (vxl_ds == null)
					continue;

				int dx = obj.Tile.Dx * TileWidth / 2;
				int dy = (obj.Tile.Dy - obj.Tile.Z) * TileHeight / 2;
				dx += _globalOffset.X;
				dy += _globalOffset.Y;
				var props = _voxels[i].Props;
				dx += props.offset.X;
				dy += props.offset.Y;
				dx -= vxl_ds.bmd.Width / 2;
				dy -= vxl_ds.bmd.Height / 2;

				BlitVoxelToSurface(ds, vxl_ds, dx, dy);
			}

		}

		private static unsafe void BlitVoxelToSurface(DrawingSurface ds, DrawingSurface vxl_ds, int dx, int dy) {
			// rows inverted!
			var w_low = (byte*)ds.bmd.Scan0;
			byte* w_high = w_low + ds.bmd.Stride * ds.bmd.Height;

			for (int y = 0; y < vxl_ds.Height; y++) {
				byte* src_row = (byte*)vxl_ds.bmd.Scan0 + vxl_ds.bmd.Stride * (vxl_ds.Height - y - 1);
				byte* dst_row = ((byte*)ds.bmd.Scan0 + (dy + y) * ds.bmd.Stride + dx * 3);
				if (dst_row < w_low || dst_row >= w_high) continue;

				for (int x = 0; x < vxl_ds.Width; x++) {
					// only non-transparent pixels
					if (*(src_row + x * 4 + 3) > 0) {
						*(dst_row + x * 3) = *(src_row + x * 4);
						*(dst_row + x * 3 + 1) = *(src_row + x * 4 + 1);
						*(dst_row + x * 3 + 2) = *(src_row + x * 4 + 2);
					}
				}
			}
		}

		private void DrawFile(GameObject obj, DrawingSurface ds, ShpFile file, DrawProperties props, Palette p = null, bool IsSHPTurret = false, bool IsAnimation = false) {
			if (file == null || obj == null || obj.Tile == null) return;

			Point offset = _globalOffset;
			offset.Offset(props.offset);

			// hacky bridge crap, somehow they have crazy offsets. hopefully this never needs to be touched again.
			var shadowOffset = offset;
			if (Overrides && obj is OverlayObject) {
				var o = obj as OverlayObject;
				if (TileWidth == 60) { // RA2
					// bridge
					if (o.IsHighBridge) {
						// 0-8 are bridge parts bottom-left -- top-right, 9-16 are top-left -- bottom right
						offset.X += o.OverlayValue <= 8 ? 0 : 0;
						offset.Y += o.OverlayValue <= 8 ? -1 : -16;
						shadowOffset.X += o.OverlayValue <= 8 ? 0 : -15;
						shadowOffset.Y += o.OverlayValue <= 8 ? -1 : -9;
					}
				}
				else { // TS
					if (o.IsTSRails) {
						offset.Y += 11;
					}
					else {
						// 0-8 are bridge parts bottom-left -- top-right, 9-16 are top-left -- bottom right
						// but perhaps they're already aligned correctly?
						offset.X += o.OverlayValue <= 8 ? 0 : 0;
						offset.Y += o.OverlayValue <= 8 ? 0 : -13;
						shadowOffset.X += o.OverlayValue <= 8 ? 0 : -15;
						shadowOffset.Y += o.OverlayValue <= 8 ? -1 : -9;
					}
				}
			}
			if (IsSHPTurret) file.Draw(TurretFrame, ds, offset, obj.Tile, p);
			else file.Draw(Frame, ds, offset, obj.Tile, p);

			if (props.hasShadow) {
				if (IsSHPTurret) file.DrawShadow(TurretFrame, ds, offset, obj.Tile);
				else file.DrawShadow(Frame, ds, offset, obj.Tile);
			}
		}

		internal void SetAlphaImage(ShpFile shpFile) {
			_alphaImage = shpFile;
		}

		internal void SetOffset(int xOffset, int yOffset) {
			_globalOffset.X = xOffset;
			_globalOffset.Y = yOffset;
		}

		internal void SetFoundation(int w, int h) {
			Foundation = new Size(w, h);
		}

		internal void AddOffset(int extraXOffset, int extraYOffset) {
			_globalOffset.X += extraXOffset;
			_globalOffset.Y += extraYOffset;
		}

		internal void AddVoxel(VxlFile vxlFile, HvaFile hvaFile, int xOffset = 0, int yOffset = 0, bool hasShadow = false, int ySort = 0) {
			_voxels.Add(new DrawableFile<VxlFile>(vxlFile, new DrawProperties(new Point(xOffset, yOffset), hasShadow, ySort), _voxels.Count));
			_hvas.Add(hvaFile);
		}

		internal void AddShp(ShpFile shpFile, int xOffset = 0, int yOffset = 0, bool hasShadow = false, int ySort = 0) {
			DrawableFile<ShpFile> d = new DrawableFile<ShpFile>(shpFile, new DrawProperties(new Point(xOffset, yOffset), hasShadow, ySort), _shps.Count);
			_shps.Add(d);
		}

		internal void AddDamagedShp(ShpFile shpFile, int xOffset = 0, int yOffset = 0, bool hasShadow = false, int ySort = 0) {
			_damagedShps.Add(new DrawableFile<ShpFile>(shpFile, new DrawProperties(new Point(xOffset, yOffset), hasShadow, ySort), _damagedShps.Count));
		}

		internal void AddFire(ShpFile shpFile, int xOffset, int yOffset, Palette firepalette) {
			// Starkku: Support for custom-paletted fire animations.
			firepalettes.Add(firepalette);
			_fires.Add(new DrawableFile<ShpFile>(shpFile, new DrawProperties(new Point(xOffset, yOffset), false, 0), _fires.Count));
		}

		internal void SetFrame(int frameNum) {
			Frame = frameNum;
		}

		public static ushort TileWidth { get; set; }
		public static ushort TileHeight { get; set; }
		public bool IsValid { get; set; }

		public override string ToString() {
			return Name;
		}

		// Starkku: Sets correct frame for building turret SHP based on building's direction.
		private void setTurretFrame(int dir) {
			switch (dir) {
				case 0:
					TurretFrame = 28;
					break;
				case 32:
					TurretFrame = 24;
					break;
				case 64:
					TurretFrame = 20;
					break;
				case 96:
					TurretFrame = 16;
					break;
				case 128:
					TurretFrame = 12;
					break;
				case 160:
					TurretFrame = 8;
					break;
				case 192:
					TurretFrame = 4;
					break;
				default:
					TurretFrame = 0;
					break;
			}
		}
	}

	class DrawableFile<T> : System.IComparable where T : VirtualFile {
		public DrawProperties Props;
		public T File;
		readonly int index;
		public DrawableFile(T file, DrawProperties drawProperties, int index) {
			this.File = file;
			Props = drawProperties;
			this.index = index;
		}

		public int CompareTo(object obj) {
			var other = obj as DrawableFile<T>;
			if (Props.ySort != other.Props.ySort)
				return Props.ySort - other.Props.ySort;
			else
				return index - other.index;
		}
	}
}