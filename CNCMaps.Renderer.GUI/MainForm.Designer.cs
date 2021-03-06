﻿using System.Windows.Forms;

namespace CNCMaps.GUI {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbMiscOptions = new System.Windows.Forms.GroupBox();
            this.gbOreGems = new System.Windows.Forms.GroupBox();
            this.lblOreEmphasisDescription = new System.Windows.Forms.Label();
            this.cbEmphasizeOre = new System.Windows.Forms.CheckBox();
            this.gbStartMarkers = new System.Windows.Forms.GroupBox();
            this.cbStartMarkers = new System.Windows.Forms.CheckBox();
            this.lblMarkerSize = new System.Windows.Forms.Label();
            this.lblStartMarkerType = new System.Windows.Forms.Label();
            this.cmbMarkerSize = new System.Windows.Forms.ComboBox();
            this.cmbStartMarkers = new System.Windows.Forms.ComboBox();
            this.lblSquaredStartPosDescription = new System.Windows.Forms.Label();
            this.gbModify = new System.Windows.Forms.GroupBox();
            this.cbCompressTiles = new System.Windows.Forms.CheckBox();
            this.cbFixOverlay = new System.Windows.Forms.CheckBox();
            this.cbBackup = new System.Windows.Forms.CheckBox();
            this.ckbFixupTiles = new System.Windows.Forms.CheckBox();
            this.gbSizeMode = new System.Windows.Forms.GroupBox();
            this.rbSizeAuto = new System.Windows.Forms.RadioButton();
            this.rbSizeFullmap = new System.Windows.Forms.RadioButton();
            this.rbSizeLocal = new System.Windows.Forms.RadioButton();
            this.gbThumbs = new System.Windows.Forms.GroupBox();
            this.lblMarkersType = new System.Windows.Forms.Label();
            this.cbMarkersType = new System.Windows.Forms.ComboBox();
            this.cbReplacePreview = new System.Windows.Forms.CheckBox();
            this.gbAdditionals = new System.Windows.Forms.GroupBox();
            this.cbTunnelPosition = new System.Windows.Forms.CheckBox();
            this.cbTunnelPaths = new System.Windows.Forms.CheckBox();
            this.cbDiagnosticWindow = new System.Windows.Forms.CheckBox();
            this.cbMarkIceGrowth = new System.Windows.Forms.CheckBox();
            this.gbInputOutput = new System.Windows.Forms.GroupBox();
            this.gbModConfig = new System.Windows.Forms.GroupBox();
            this.btnModEditor = new System.Windows.Forms.Button();
            this.tbModConfig = new System.Windows.Forms.TextBox();
            this.cbModConfig = new System.Windows.Forms.CheckBox();
            this.gbFilename = new System.Windows.Forms.GroupBox();
            this.rbUseFilename = new System.Windows.Forms.RadioButton();
            this.tbCustomOutput = new System.Windows.Forms.TextBox();
            this.rbCustomFilename = new System.Windows.Forms.RadioButton();
            this.rbAutoFilename = new System.Windows.Forms.RadioButton();
            this.gbImageFormat = new System.Windows.Forms.GroupBox();
            this.cbThumbPNG = new System.Windows.Forms.CheckBox();
            this.cbPreserveThumbAspect = new System.Windows.Forms.CheckBox();
            this.tbThumbDimensions = new System.Windows.Forms.TextBox();
            this.cbOutputThumbnail = new System.Windows.Forms.CheckBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblCompressionLevel = new System.Windows.Forms.Label();
            this.nudEncodingQuality = new System.Windows.Forms.NumericUpDown();
            this.cbOutputJPG = new System.Windows.Forms.CheckBox();
            this.cbOutputPNG = new System.Windows.Forms.CheckBox();
            this.nudCompression = new System.Windows.Forms.NumericUpDown();
            this.pnlEngine = new System.Windows.Forms.Panel();
            this.rbEngineFS = new System.Windows.Forms.RadioButton();
            this.rbEngineTS = new System.Windows.Forms.RadioButton();
            this.rbEngineAuto = new System.Windows.Forms.RadioButton();
            this.rbEngineRA2 = new System.Windows.Forms.RadioButton();
            this.rbEngineYR = new System.Windows.Forms.RadioButton();
            this.lbEngine = new System.Windows.Forms.Label();
            this.tbMixDir = new System.Windows.Forms.TextBox();
            this.lblMixFiles = new System.Windows.Forms.Label();
            this.btnBrowseMixDir = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblInputMap = new System.Windows.Forms.Label();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.btnRenderExecute = new System.Windows.Forms.Button();
            this.tbCommandPreview = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFill = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.lblCommand = new System.Windows.Forms.Label();
            this.tpMisc = new System.Windows.Forms.TabPage();
            this.tpBatch = new System.Windows.Forms.TabPage();
            this.gbBatchRender = new System.Windows.Forms.GroupBox();
            this.btnBatchRender = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBatchInput = new System.Windows.Forms.TextBox();
            this.btnBrowseMaps = new System.Windows.Forms.Button();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMiscOptions.SuspendLayout();
            this.gbOreGems.SuspendLayout();
            this.gbStartMarkers.SuspendLayout();
            this.gbModify.SuspendLayout();
            this.gbSizeMode.SuspendLayout();
            this.gbThumbs.SuspendLayout();
            this.gbAdditionals.SuspendLayout();
            this.gbInputOutput.SuspendLayout();
            this.gbModConfig.SuspendLayout();
            this.gbFilename.SuspendLayout();
            this.gbImageFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncodingQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).BeginInit();
            this.pnlEngine.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpMisc.SuspendLayout();
            this.tpBatch.SuspendLayout();
            this.gbBatchRender.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMiscOptions
            // 
            this.gbMiscOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMiscOptions.Controls.Add(this.gbOreGems);
            this.gbMiscOptions.Controls.Add(this.gbStartMarkers);
            this.gbMiscOptions.Controls.Add(this.gbModify);
            this.gbMiscOptions.Controls.Add(this.gbSizeMode);
            this.gbMiscOptions.Controls.Add(this.gbThumbs);
            this.gbMiscOptions.Controls.Add(this.gbAdditionals);
            this.gbMiscOptions.Location = new System.Drawing.Point(6, 6);
            this.gbMiscOptions.Name = "gbMiscOptions";
            this.gbMiscOptions.Size = new System.Drawing.Size(583, 330);
            this.gbMiscOptions.TabIndex = 1;
            this.gbMiscOptions.TabStop = false;
            this.gbMiscOptions.Text = "Misc. Options";
            this.gbMiscOptions.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.gbMiscOptions.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // gbOreGems
            // 
            this.gbOreGems.Controls.Add(this.lblOreEmphasisDescription);
            this.gbOreGems.Controls.Add(this.cbEmphasizeOre);
            this.gbOreGems.Location = new System.Drawing.Point(13, 11);
            this.gbOreGems.Name = "gbOreGems";
            this.gbOreGems.Size = new System.Drawing.Size(546, 59);
            this.gbOreGems.TabIndex = 38;
            this.gbOreGems.TabStop = false;
            // 
            // lblOreEmphasisDescription
            // 
            this.lblOreEmphasisDescription.Location = new System.Drawing.Point(14, 26);
            this.lblOreEmphasisDescription.Name = "lblOreEmphasisDescription";
            this.lblOreEmphasisDescription.Size = new System.Drawing.Size(524, 29);
            this.lblOreEmphasisDescription.TabIndex = 1;
            this.lblOreEmphasisDescription.Text = resources.GetString("lblOreEmphasisDescription.Text");
            // 
            // cbEmphasizeOre
            // 
            this.cbEmphasizeOre.AutoSize = true;
            this.cbEmphasizeOre.Location = new System.Drawing.Point(16, 10);
            this.cbEmphasizeOre.Name = "cbEmphasizeOre";
            this.cbEmphasizeOre.Size = new System.Drawing.Size(125, 17);
            this.cbEmphasizeOre.TabIndex = 0;
            this.cbEmphasizeOre.Text = "Emphasize ore/gems";
            this.cbEmphasizeOre.UseVisualStyleBackColor = true;
            this.cbEmphasizeOre.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // gbStartMarkers
            // 
            this.gbStartMarkers.Controls.Add(this.cbStartMarkers);
            this.gbStartMarkers.Controls.Add(this.lblMarkerSize);
            this.gbStartMarkers.Controls.Add(this.lblStartMarkerType);
            this.gbStartMarkers.Controls.Add(this.cmbMarkerSize);
            this.gbStartMarkers.Controls.Add(this.cmbStartMarkers);
            this.gbStartMarkers.Controls.Add(this.lblSquaredStartPosDescription);
            this.gbStartMarkers.Location = new System.Drawing.Point(13, 72);
            this.gbStartMarkers.Name = "gbStartMarkers";
            this.gbStartMarkers.Size = new System.Drawing.Size(547, 64);
            this.gbStartMarkers.TabIndex = 37;
            this.gbStartMarkers.TabStop = false;
            // 
            // cbStartMarkers
            // 
            this.cbStartMarkers.AutoSize = true;
            this.cbStartMarkers.Location = new System.Drawing.Point(16, 11);
            this.cbStartMarkers.Name = "cbStartMarkers";
            this.cbStartMarkers.Size = new System.Drawing.Size(207, 17);
            this.cbStartMarkers.TabIndex = 5;
            this.cbStartMarkers.Text = "Place markers at the starting positions.";
            this.cbStartMarkers.UseVisualStyleBackColor = true;
            this.cbStartMarkers.CheckedChanged += new System.EventHandler(this.cbStartMarkers_CheckedChanged);
            // 
            // lblMarkerSize
            // 
            this.lblMarkerSize.AutoSize = true;
            this.lblMarkerSize.Location = new System.Drawing.Point(446, 14);
            this.lblMarkerSize.Name = "lblMarkerSize";
            this.lblMarkerSize.Size = new System.Drawing.Size(63, 13);
            this.lblMarkerSize.TabIndex = 36;
            this.lblMarkerSize.Text = "Marker Size";
            // 
            // lblStartMarkerType
            // 
            this.lblStartMarkerType.AutoSize = true;
            this.lblStartMarkerType.Location = new System.Drawing.Point(338, 14);
            this.lblStartMarkerType.Name = "lblStartMarkerType";
            this.lblStartMarkerType.Size = new System.Drawing.Size(72, 13);
            this.lblStartMarkerType.TabIndex = 35;
            this.lblStartMarkerType.Text = "Marker Types";
            // 
            // cmbMarkerSize
            // 
            this.cmbMarkerSize.FormattingEnabled = true;
            this.cmbMarkerSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbMarkerSize.Location = new System.Drawing.Point(449, 28);
            this.cmbMarkerSize.Name = "cmbMarkerSize";
            this.cmbMarkerSize.Size = new System.Drawing.Size(59, 21);
            this.cmbMarkerSize.TabIndex = 10;
            this.cmbMarkerSize.Text = "4";
            this.cmbMarkerSize.SelectedIndexChanged += new System.EventHandler(this.cmbMarkerSize_SelectedIndexChanged);
            // 
            // cmbStartMarkers
            // 
            this.cmbStartMarkers.FormattingEnabled = true;
            this.cmbStartMarkers.Items.AddRange(new object[] {
            "None",
            "Squared",
            "Circled",
            "Diamond",
            "Ellipsed",
            "Tiled"});
            this.cmbStartMarkers.Location = new System.Drawing.Point(341, 28);
            this.cmbStartMarkers.Name = "cmbStartMarkers";
            this.cmbStartMarkers.Size = new System.Drawing.Size(99, 21);
            this.cmbStartMarkers.TabIndex = 8;
            this.cmbStartMarkers.Text = "Diamond";
            this.cmbStartMarkers.SelectedIndexChanged += new System.EventHandler(this.cmbStartMarkers_SelectedIndexChanged);
            // 
            // lblSquaredStartPosDescription
            // 
            this.lblSquaredStartPosDescription.Location = new System.Drawing.Point(14, 28);
            this.lblSquaredStartPosDescription.Name = "lblSquaredStartPosDescription";
            this.lblSquaredStartPosDescription.Size = new System.Drawing.Size(334, 28);
            this.lblSquaredStartPosDescription.TabIndex = 3;
            this.lblSquaredStartPosDescription.Text = "Tiled marker option colors the tile itself whereas other options paint the marker" +
    " at the starting locations.";
            // 
            // gbModify
            // 
            this.gbModify.Controls.Add(this.cbCompressTiles);
            this.gbModify.Controls.Add(this.cbFixOverlay);
            this.gbModify.Controls.Add(this.cbBackup);
            this.gbModify.Controls.Add(this.ckbFixupTiles);
            this.gbModify.Location = new System.Drawing.Point(13, 261);
            this.gbModify.Name = "gbModify";
            this.gbModify.Size = new System.Drawing.Size(547, 63);
            this.gbModify.TabIndex = 32;
            this.gbModify.TabStop = false;
            this.gbModify.Text = "Modify map";
            // 
            // cbCompressTiles
            // 
            this.cbCompressTiles.AutoSize = true;
            this.cbCompressTiles.Location = new System.Drawing.Point(243, 17);
            this.cbCompressTiles.Name = "cbCompressTiles";
            this.cbCompressTiles.Size = new System.Drawing.Size(125, 17);
            this.cbCompressTiles.TabIndex = 33;
            this.cbCompressTiles.Text = "Compress Tiles Pack";
            this.toolTip.SetToolTip(this.cbCompressTiles, "Compress IsoMapPack5 section in map, undone by FinalSun or FinalAlert2");
            this.cbCompressTiles.UseVisualStyleBackColor = true;
            this.cbCompressTiles.CheckedChanged += new System.EventHandler(this.cbCompressTiles_CheckedChanged);
            // 
            // cbFixOverlay
            // 
            this.cbFixOverlay.AutoSize = true;
            this.cbFixOverlay.Location = new System.Drawing.Point(16, 40);
            this.cbFixOverlay.Name = "cbFixOverlay";
            this.cbFixOverlay.Size = new System.Drawing.Size(83, 17);
            this.cbFixOverlay.TabIndex = 32;
            this.cbFixOverlay.Text = "Fix Overlays";
            this.toolTip.SetToolTip(this.cbFixOverlay, "Remove undefined overlays and overwrite overlay sections in map");
            this.cbFixOverlay.UseVisualStyleBackColor = true;
            this.cbFixOverlay.CheckedChanged += new System.EventHandler(this.cbFixOverlay_CheckedChanged);
            // 
            // cbBackup
            // 
            this.cbBackup.AutoSize = true;
            this.cbBackup.Checked = true;
            this.cbBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackup.Location = new System.Drawing.Point(243, 40);
            this.cbBackup.Name = "cbBackup";
            this.cbBackup.Size = new System.Drawing.Size(87, 17);
            this.cbBackup.TabIndex = 34;
            this.cbBackup.Text = "Map Backup";
            this.toolTip.SetToolTip(this.cbBackup, "Create backup when modifying map file");
            this.cbBackup.UseVisualStyleBackColor = true;
            this.cbBackup.CheckedChanged += new System.EventHandler(this.cbBackup_CheckedChanged);
            // 
            // ckbFixupTiles
            // 
            this.ckbFixupTiles.AutoSize = true;
            this.ckbFixupTiles.Location = new System.Drawing.Point(16, 17);
            this.ckbFixupTiles.Name = "ckbFixupTiles";
            this.ckbFixupTiles.Size = new System.Drawing.Size(64, 17);
            this.ckbFixupTiles.TabIndex = 31;
            this.ckbFixupTiles.Text = "Fix Tiles";
            this.toolTip.SetToolTip(this.ckbFixupTiles, "Remove undefined tiles and overwrite IsoMapPack5 section in map");
            this.ckbFixupTiles.UseVisualStyleBackColor = true;
            this.ckbFixupTiles.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // gbSizeMode
            // 
            this.gbSizeMode.Controls.Add(this.rbSizeAuto);
            this.gbSizeMode.Controls.Add(this.rbSizeFullmap);
            this.gbSizeMode.Controls.Add(this.rbSizeLocal);
            this.gbSizeMode.Location = new System.Drawing.Point(13, 180);
            this.gbSizeMode.Name = "gbSizeMode";
            this.gbSizeMode.Size = new System.Drawing.Size(547, 26);
            this.gbSizeMode.TabIndex = 18;
            this.gbSizeMode.TabStop = false;
            // 
            // rbSizeAuto
            // 
            this.rbSizeAuto.AutoSize = true;
            this.rbSizeAuto.Checked = true;
            this.rbSizeAuto.Location = new System.Drawing.Point(16, 6);
            this.rbSizeAuto.Name = "rbSizeAuto";
            this.rbSizeAuto.Size = new System.Drawing.Size(68, 17);
            this.rbSizeAuto.TabIndex = 18;
            this.rbSizeAuto.TabStop = true;
            this.rbSizeAuto.Text = "Auto size";
            this.toolTip.SetToolTip(this.rbSizeAuto, "Saves the portion of the map that is visible in game.");
            this.rbSizeAuto.UseVisualStyleBackColor = true;
            // 
            // rbSizeFullmap
            // 
            this.rbSizeFullmap.AutoSize = true;
            this.rbSizeFullmap.Location = new System.Drawing.Point(338, 6);
            this.rbSizeFullmap.Name = "rbSizeFullmap";
            this.rbSizeFullmap.Size = new System.Drawing.Size(175, 17);
            this.rbSizeFullmap.TabIndex = 22;
            this.rbSizeFullmap.Text = "Use full size (useful for missions)";
            this.toolTip.SetToolTip(this.rbSizeFullmap, "Saves the entire map without cutting off the parts outside the LocalSize entry.\r\n" +
        "This is especially useful for campaign maps where the map expands after\r\nachievi" +
        "ng some objective.");
            this.rbSizeFullmap.UseVisualStyleBackColor = true;
            this.rbSizeFullmap.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // rbSizeLocal
            // 
            this.rbSizeLocal.AutoSize = true;
            this.rbSizeLocal.Location = new System.Drawing.Point(164, 6);
            this.rbSizeLocal.Name = "rbSizeLocal";
            this.rbSizeLocal.Size = new System.Drawing.Size(110, 17);
            this.rbSizeLocal.TabIndex = 20;
            this.rbSizeLocal.Text = "Use map localsize";
            this.toolTip.SetToolTip(this.rbSizeLocal, "Saves the portion of the map that is visible in game.");
            this.rbSizeLocal.UseVisualStyleBackColor = true;
            this.rbSizeLocal.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // gbThumbs
            // 
            this.gbThumbs.Controls.Add(this.lblMarkersType);
            this.gbThumbs.Controls.Add(this.cbMarkersType);
            this.gbThumbs.Controls.Add(this.cbReplacePreview);
            this.gbThumbs.Location = new System.Drawing.Point(13, 138);
            this.gbThumbs.Name = "gbThumbs";
            this.gbThumbs.Size = new System.Drawing.Size(547, 39);
            this.gbThumbs.TabIndex = 20;
            this.gbThumbs.TabStop = false;
            this.gbThumbs.Text = "Thumbnail injection (Modifies map)";
            // 
            // lblMarkersType
            // 
            this.lblMarkersType.AutoSize = true;
            this.lblMarkersType.Location = new System.Drawing.Point(338, 15);
            this.lblMarkersType.Name = "lblMarkersType";
            this.lblMarkersType.Size = new System.Drawing.Size(48, 13);
            this.lblMarkersType.TabIndex = 19;
            this.lblMarkersType.Text = "Markers:";
            // 
            // cbMarkersType
            // 
            this.cbMarkersType.FormattingEnabled = true;
            this.cbMarkersType.Items.AddRange(new object[] {
            "None",
            "SelectedAsAbove",
            "Aro",
            "Bittah"});
            this.cbMarkersType.Location = new System.Drawing.Point(387, 12);
            this.cbMarkersType.Name = "cbMarkersType";
            this.cbMarkersType.Size = new System.Drawing.Size(121, 21);
            this.cbMarkersType.TabIndex = 18;
            this.cbMarkersType.Text = "None";
            this.cbMarkersType.SelectedIndexChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbReplacePreview
            // 
            this.cbReplacePreview.AutoSize = true;
            this.cbReplacePreview.Location = new System.Drawing.Point(16, 15);
            this.cbReplacePreview.Name = "cbReplacePreview";
            this.cbReplacePreview.Size = new System.Drawing.Size(284, 17);
            this.cbReplacePreview.TabIndex = 15;
            this.cbReplacePreview.Text = "Replace map preview with thumbnail of resulting image";
            this.toolTip.SetToolTip(this.cbReplacePreview, resources.GetString("cbReplacePreview.ToolTip"));
            this.cbReplacePreview.UseVisualStyleBackColor = true;
            this.cbReplacePreview.CheckedChanged += new System.EventHandler(this.CbReplacePreviewCheckedChanged);
            // 
            // gbAdditionals
            // 
            this.gbAdditionals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdditionals.Controls.Add(this.cbTunnelPosition);
            this.gbAdditionals.Controls.Add(this.cbTunnelPaths);
            this.gbAdditionals.Controls.Add(this.cbDiagnosticWindow);
            this.gbAdditionals.Controls.Add(this.cbMarkIceGrowth);
            this.gbAdditionals.Location = new System.Drawing.Point(13, 209);
            this.gbAdditionals.Name = "gbAdditionals";
            this.gbAdditionals.Size = new System.Drawing.Size(547, 52);
            this.gbAdditionals.TabIndex = 19;
            this.gbAdditionals.TabStop = false;
            // 
            // cbTunnelPosition
            // 
            this.cbTunnelPosition.AutoSize = true;
            this.cbTunnelPosition.Checked = true;
            this.cbTunnelPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTunnelPosition.Enabled = false;
            this.cbTunnelPosition.Location = new System.Drawing.Point(16, 30);
            this.cbTunnelPosition.Name = "cbTunnelPosition";
            this.cbTunnelPosition.Size = new System.Drawing.Size(141, 17);
            this.cbTunnelPosition.TabIndex = 25;
            this.cbTunnelPosition.Text = "Raise tunnel lines height";
            this.toolTip.SetToolTip(this.cbTunnelPosition, "Raise the height of tunnel lines by 4 cells to compensate for tunnel entrance gra" +
        "phics");
            this.cbTunnelPosition.UseVisualStyleBackColor = true;
            this.cbTunnelPosition.CheckedChanged += new System.EventHandler(this.cbTunnelPosition_CheckedChanged);
            // 
            // cbTunnelPaths
            // 
            this.cbTunnelPaths.AutoSize = true;
            this.cbTunnelPaths.Location = new System.Drawing.Point(16, 10);
            this.cbTunnelPaths.Name = "cbTunnelPaths";
            this.cbTunnelPaths.Size = new System.Drawing.Size(114, 17);
            this.cbTunnelPaths.TabIndex = 24;
            this.cbTunnelPaths.Text = "Show tunnel paths";
            this.toolTip.SetToolTip(this.cbTunnelPaths, "Show tunnel path lines.");
            this.cbTunnelPaths.UseVisualStyleBackColor = true;
            this.cbTunnelPaths.CheckedChanged += new System.EventHandler(this.cbTunnelPaths_CheckedChanged);
            // 
            // cbDiagnosticWindow
            // 
            this.cbDiagnosticWindow.AutoSize = true;
            this.cbDiagnosticWindow.Location = new System.Drawing.Point(338, 10);
            this.cbDiagnosticWindow.Name = "cbDiagnosticWindow";
            this.cbDiagnosticWindow.Size = new System.Drawing.Size(132, 17);
            this.cbDiagnosticWindow.TabIndex = 28;
            this.cbDiagnosticWindow.Text = "Show preview window";
            this.toolTip.SetToolTip(this.cbDiagnosticWindow, "Show diagnostic window");
            this.cbDiagnosticWindow.UseVisualStyleBackColor = true;
            this.cbDiagnosticWindow.CheckedChanged += new System.EventHandler(this.cbDiagnosticWindow_CheckedChanged);
            // 
            // cbMarkIceGrowth
            // 
            this.cbMarkIceGrowth.AutoSize = true;
            this.cbMarkIceGrowth.Location = new System.Drawing.Point(165, 10);
            this.cbMarkIceGrowth.Name = "cbMarkIceGrowth";
            this.cbMarkIceGrowth.Size = new System.Drawing.Size(102, 17);
            this.cbMarkIceGrowth.TabIndex = 27;
            this.cbMarkIceGrowth.Text = "Mark ice growth";
            this.toolTip.SetToolTip(this.cbMarkIceGrowth, "Marks the cells having ice growth set, used in TS Snow maps");
            this.cbMarkIceGrowth.UseVisualStyleBackColor = true;
            this.cbMarkIceGrowth.CheckedChanged += new System.EventHandler(this.cbMarkIceGrowth_CheckedChanged);
            // 
            // gbInputOutput
            // 
            this.gbInputOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInputOutput.Controls.Add(this.gbModConfig);
            this.gbInputOutput.Controls.Add(this.gbFilename);
            this.gbInputOutput.Controls.Add(this.gbImageFormat);
            this.gbInputOutput.Controls.Add(this.pnlEngine);
            this.gbInputOutput.Controls.Add(this.tbMixDir);
            this.gbInputOutput.Controls.Add(this.lblMixFiles);
            this.gbInputOutput.Controls.Add(this.btnBrowseMixDir);
            this.gbInputOutput.Controls.Add(this.tbInput);
            this.gbInputOutput.Controls.Add(this.lblInputMap);
            this.gbInputOutput.Controls.Add(this.btnBrowseInput);
            this.gbInputOutput.Location = new System.Drawing.Point(6, 6);
            this.gbInputOutput.Name = "gbInputOutput";
            this.gbInputOutput.Size = new System.Drawing.Size(581, 269);
            this.gbInputOutput.TabIndex = 0;
            this.gbInputOutput.TabStop = false;
            this.gbInputOutput.Text = "Input && output";
            this.gbInputOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.gbInputOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // gbModConfig
            // 
            this.gbModConfig.Controls.Add(this.btnModEditor);
            this.gbModConfig.Controls.Add(this.tbModConfig);
            this.gbModConfig.Controls.Add(this.cbModConfig);
            this.gbModConfig.Location = new System.Drawing.Point(8, 217);
            this.gbModConfig.Name = "gbModConfig";
            this.gbModConfig.Size = new System.Drawing.Size(567, 42);
            this.gbModConfig.TabIndex = 44;
            this.gbModConfig.TabStop = false;
            // 
            // btnModEditor
            // 
            this.btnModEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModEditor.Location = new System.Drawing.Point(487, 13);
            this.btnModEditor.Name = "btnModEditor";
            this.btnModEditor.Size = new System.Drawing.Size(75, 20);
            this.btnModEditor.TabIndex = 28;
            this.btnModEditor.Text = "Open editor";
            this.btnModEditor.UseVisualStyleBackColor = true;
            this.btnModEditor.Visible = false;
            this.btnModEditor.Click += new System.EventHandler(this.BtnModEditorClick);
            // 
            // tbModConfig
            // 
            this.tbModConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModConfig.Location = new System.Drawing.Point(154, 13);
            this.tbModConfig.Name = "tbModConfig";
            this.tbModConfig.Size = new System.Drawing.Size(327, 20);
            this.tbModConfig.TabIndex = 24;
            this.tbModConfig.Visible = false;
            this.tbModConfig.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbModConfig
            // 
            this.cbModConfig.AutoSize = true;
            this.cbModConfig.Location = new System.Drawing.Point(8, 15);
            this.cbModConfig.Name = "cbModConfig";
            this.cbModConfig.Size = new System.Drawing.Size(141, 17);
            this.cbModConfig.TabIndex = 26;
            this.cbModConfig.Text = "Load special mod config";
            this.toolTip.SetToolTip(this.cbModConfig, "Special mod configs allow you to specify precisely which extra directories, mixes" +
        "\r\nand theater specific settings should be considered for your mod.");
            this.cbModConfig.UseVisualStyleBackColor = true;
            this.cbModConfig.CheckedChanged += new System.EventHandler(this.cbModConfig_CheckedChanged);
            // 
            // gbFilename
            // 
            this.gbFilename.Controls.Add(this.rbUseFilename);
            this.gbFilename.Controls.Add(this.tbCustomOutput);
            this.gbFilename.Controls.Add(this.rbCustomFilename);
            this.gbFilename.Controls.Add(this.rbAutoFilename);
            this.gbFilename.Location = new System.Drawing.Point(8, 130);
            this.gbFilename.Name = "gbFilename";
            this.gbFilename.Size = new System.Drawing.Size(567, 36);
            this.gbFilename.TabIndex = 43;
            this.gbFilename.TabStop = false;
            // 
            // rbUseFilename
            // 
            this.rbUseFilename.AutoSize = true;
            this.rbUseFilename.Checked = true;
            this.rbUseFilename.Location = new System.Drawing.Point(8, 12);
            this.rbUseFilename.Name = "rbUseFilename";
            this.rbUseFilename.Size = new System.Drawing.Size(86, 17);
            this.rbUseFilename.TabIndex = 14;
            this.rbUseFilename.TabStop = true;
            this.rbUseFilename.Text = "Use filename";
            this.toolTip.SetToolTip(this.rbUseFilename, "Use input filename for output");
            this.rbUseFilename.UseVisualStyleBackColor = true;
            this.rbUseFilename.CheckedChanged += new System.EventHandler(this.rbUseFilename_CheckedChanged);
            // 
            // tbCustomOutput
            // 
            this.tbCustomOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomOutput.Location = new System.Drawing.Point(334, 11);
            this.tbCustomOutput.Name = "tbCustomOutput";
            this.tbCustomOutput.Size = new System.Drawing.Size(228, 20);
            this.tbCustomOutput.TabIndex = 17;
            this.tbCustomOutput.Visible = false;
            this.tbCustomOutput.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // rbCustomFilename
            // 
            this.rbCustomFilename.AutoSize = true;
            this.rbCustomFilename.Location = new System.Drawing.Point(227, 12);
            this.rbCustomFilename.Name = "rbCustomFilename";
            this.rbCustomFilename.Size = new System.Drawing.Size(102, 17);
            this.rbCustomFilename.TabIndex = 16;
            this.rbCustomFilename.TabStop = true;
            this.rbCustomFilename.Text = "Custom filename";
            this.toolTip.SetToolTip(this.rbCustomFilename, "Overrides the output name with the given name by user. \r\nThe .jpg and .png extens" +
        "ions are automatically added.");
            this.rbCustomFilename.UseVisualStyleBackColor = true;
            this.rbCustomFilename.CheckedChanged += new System.EventHandler(this.OutputNameCheckedChanged);
            // 
            // rbAutoFilename
            // 
            this.rbAutoFilename.AutoSize = true;
            this.rbAutoFilename.Location = new System.Drawing.Point(101, 12);
            this.rbAutoFilename.Name = "rbAutoFilename";
            this.rbAutoFilename.Size = new System.Drawing.Size(121, 17);
            this.rbAutoFilename.TabIndex = 15;
            this.rbAutoFilename.TabStop = true;
            this.rbAutoFilename.Text = "Automatic mapname";
            this.toolTip.SetToolTip(this.rbAutoFilename, resources.GetString("rbAutoFilename.ToolTip"));
            this.rbAutoFilename.UseVisualStyleBackColor = true;
            this.rbAutoFilename.CheckedChanged += new System.EventHandler(this.OutputNameCheckedChanged);
            // 
            // gbImageFormat
            // 
            this.gbImageFormat.Controls.Add(this.cbThumbPNG);
            this.gbImageFormat.Controls.Add(this.cbPreserveThumbAspect);
            this.gbImageFormat.Controls.Add(this.tbThumbDimensions);
            this.gbImageFormat.Controls.Add(this.cbOutputThumbnail);
            this.gbImageFormat.Controls.Add(this.lblQuality);
            this.gbImageFormat.Controls.Add(this.lblCompressionLevel);
            this.gbImageFormat.Controls.Add(this.nudEncodingQuality);
            this.gbImageFormat.Controls.Add(this.cbOutputJPG);
            this.gbImageFormat.Controls.Add(this.cbOutputPNG);
            this.gbImageFormat.Controls.Add(this.nudCompression);
            this.gbImageFormat.Location = new System.Drawing.Point(8, 67);
            this.gbImageFormat.Name = "gbImageFormat";
            this.gbImageFormat.Size = new System.Drawing.Size(567, 64);
            this.gbImageFormat.TabIndex = 42;
            this.gbImageFormat.TabStop = false;
            // 
            // cbThumbPNG
            // 
            this.cbThumbPNG.AutoSize = true;
            this.cbThumbPNG.Checked = true;
            this.cbThumbPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThumbPNG.Location = new System.Drawing.Point(441, 37);
            this.cbThumbPNG.Name = "cbThumbPNG";
            this.cbThumbPNG.Size = new System.Drawing.Size(84, 17);
            this.cbThumbPNG.TabIndex = 11;
            this.cbThumbPNG.Text = "Output PNG";
            this.toolTip.SetToolTip(this.cbThumbPNG, "Save generated thumbnails as PNG images, instead of JPEG.");
            this.cbThumbPNG.UseVisualStyleBackColor = true;
            this.cbThumbPNG.Visible = false;
            this.cbThumbPNG.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbPreserveThumbAspect
            // 
            this.cbPreserveThumbAspect.AutoSize = true;
            this.cbPreserveThumbAspect.Checked = true;
            this.cbPreserveThumbAspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreserveThumbAspect.Location = new System.Drawing.Point(441, 13);
            this.cbPreserveThumbAspect.Name = "cbPreserveThumbAspect";
            this.cbPreserveThumbAspect.Size = new System.Drawing.Size(126, 17);
            this.cbPreserveThumbAspect.TabIndex = 10;
            this.cbPreserveThumbAspect.Text = "Preserve aspect ratio";
            this.toolTip.SetToolTip(this.cbPreserveThumbAspect, resources.GetString("cbPreserveThumbAspect.ToolTip"));
            this.cbPreserveThumbAspect.UseVisualStyleBackColor = true;
            this.cbPreserveThumbAspect.Visible = false;
            this.cbPreserveThumbAspect.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // tbThumbDimensions
            // 
            this.tbThumbDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbThumbDimensions.Location = new System.Drawing.Point(382, 12);
            this.tbThumbDimensions.Name = "tbThumbDimensions";
            this.tbThumbDimensions.Size = new System.Drawing.Size(46, 20);
            this.tbThumbDimensions.TabIndex = 9;
            this.tbThumbDimensions.Text = "800,0";
            this.tbThumbDimensions.Visible = false;
            // 
            // cbOutputThumbnail
            // 
            this.cbOutputThumbnail.AutoSize = true;
            this.cbOutputThumbnail.Location = new System.Drawing.Point(276, 13);
            this.cbOutputThumbnail.Name = "cbOutputThumbnail";
            this.cbOutputThumbnail.Size = new System.Drawing.Size(106, 17);
            this.cbOutputThumbnail.TabIndex = 8;
            this.cbOutputThumbnail.Text = "Output thumbnail";
            this.toolTip.SetToolTip(this.cbOutputThumbnail, resources.GetString("cbOutputThumbnail.ToolTip"));
            this.cbOutputThumbnail.UseVisualStyleBackColor = true;
            this.cbOutputThumbnail.CheckedChanged += new System.EventHandler(this.CbOutputThumbnailCheckedChanged);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(113, 13);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(85, 13);
            this.lblQuality.TabIndex = 5;
            this.lblQuality.Text = "Encoding quality";
            this.toolTip.SetToolTip(this.lblQuality, "JPEG encoding quality, between 1-100 with 100 resulting in the largest file in th" +
        "e highest quality.");
            this.lblQuality.Visible = false;
            // 
            // lblCompressionLevel
            // 
            this.lblCompressionLevel.AutoSize = true;
            this.lblCompressionLevel.Location = new System.Drawing.Point(113, 38);
            this.lblCompressionLevel.Name = "lblCompressionLevel";
            this.lblCompressionLevel.Size = new System.Drawing.Size(92, 13);
            this.lblCompressionLevel.TabIndex = 1;
            this.lblCompressionLevel.Text = "Compression level";
            this.toolTip.SetToolTip(this.lblCompressionLevel, "PNG compression level ranging from 1-9, 9 resulting in the smallest file but also" +
        " in longest loading time.");
            // 
            // nudEncodingQuality
            // 
            this.nudEncodingQuality.Location = new System.Drawing.Point(216, 12);
            this.nudEncodingQuality.Name = "nudEncodingQuality";
            this.nudEncodingQuality.Size = new System.Drawing.Size(43, 20);
            this.nudEncodingQuality.TabIndex = 7;
            this.nudEncodingQuality.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudEncodingQuality.Visible = false;
            this.nudEncodingQuality.ValueChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbOutputJPG
            // 
            this.cbOutputJPG.AutoSize = true;
            this.cbOutputJPG.Location = new System.Drawing.Point(11, 13);
            this.cbOutputJPG.Name = "cbOutputJPG";
            this.cbOutputJPG.Size = new System.Drawing.Size(81, 17);
            this.cbOutputJPG.TabIndex = 6;
            this.cbOutputJPG.Text = "Output JPG";
            this.toolTip.SetToolTip(this.cbOutputJPG, "Specifies whether or not a JPEG compressed image is saved.\r\nImages are always sav" +
        "ed in the same directory as the input map.");
            this.cbOutputJPG.UseVisualStyleBackColor = true;
            this.cbOutputJPG.CheckedChanged += new System.EventHandler(this.JpegOutputCheckedChanged);
            // 
            // cbOutputPNG
            // 
            this.cbOutputPNG.AutoSize = true;
            this.cbOutputPNG.Checked = true;
            this.cbOutputPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOutputPNG.Location = new System.Drawing.Point(11, 37);
            this.cbOutputPNG.Name = "cbOutputPNG";
            this.cbOutputPNG.Size = new System.Drawing.Size(84, 17);
            this.cbOutputPNG.TabIndex = 12;
            this.cbOutputPNG.Text = "Output PNG";
            this.toolTip.SetToolTip(this.cbOutputPNG, "Specifies whether or not a PNG compressed image is saved.");
            this.cbOutputPNG.UseVisualStyleBackColor = true;
            this.cbOutputPNG.CheckedChanged += new System.EventHandler(this.PngOutputCheckedChanged);
            // 
            // nudCompression
            // 
            this.nudCompression.Location = new System.Drawing.Point(216, 37);
            this.nudCompression.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudCompression.Name = "nudCompression";
            this.nudCompression.Size = new System.Drawing.Size(43, 20);
            this.nudCompression.TabIndex = 13;
            this.nudCompression.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCompression.ValueChanged += new System.EventHandler(this.UIChanged);
            // 
            // pnlEngine
            // 
            this.pnlEngine.Controls.Add(this.rbEngineFS);
            this.pnlEngine.Controls.Add(this.rbEngineTS);
            this.pnlEngine.Controls.Add(this.rbEngineAuto);
            this.pnlEngine.Controls.Add(this.rbEngineRA2);
            this.pnlEngine.Controls.Add(this.rbEngineYR);
            this.pnlEngine.Controls.Add(this.lbEngine);
            this.pnlEngine.Location = new System.Drawing.Point(8, 172);
            this.pnlEngine.Name = "pnlEngine";
            this.pnlEngine.Size = new System.Drawing.Size(567, 43);
            this.pnlEngine.TabIndex = 41;
            // 
            // rbEngineFS
            // 
            this.rbEngineFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineFS.AutoSize = true;
            this.rbEngineFS.Location = new System.Drawing.Point(384, 22);
            this.rbEngineFS.Name = "rbEngineFS";
            this.rbEngineFS.Size = new System.Drawing.Size(68, 17);
            this.rbEngineFS.TabIndex = 24;
            this.rbEngineFS.TabStop = true;
            this.rbEngineFS.Text = "Force FS";
            this.rbEngineFS.UseVisualStyleBackColor = true;
            this.rbEngineFS.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // rbEngineTS
            // 
            this.rbEngineTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineTS.AutoSize = true;
            this.rbEngineTS.Location = new System.Drawing.Point(290, 22);
            this.rbEngineTS.Name = "rbEngineTS";
            this.rbEngineTS.Size = new System.Drawing.Size(69, 17);
            this.rbEngineTS.TabIndex = 22;
            this.rbEngineTS.TabStop = true;
            this.rbEngineTS.Text = "Force TS";
            this.rbEngineTS.UseVisualStyleBackColor = true;
            this.rbEngineTS.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // rbEngineAuto
            // 
            this.rbEngineAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineAuto.AutoSize = true;
            this.rbEngineAuto.Checked = true;
            this.rbEngineAuto.Location = new System.Drawing.Point(8, 22);
            this.rbEngineAuto.Name = "rbEngineAuto";
            this.rbEngineAuto.Size = new System.Drawing.Size(82, 17);
            this.rbEngineAuto.TabIndex = 18;
            this.rbEngineAuto.TabStop = true;
            this.rbEngineAuto.Text = "Auto Detect";
            this.toolTip.SetToolTip(this.rbEngineAuto, resources.GetString("rbEngineAuto.ToolTip"));
            this.rbEngineAuto.UseVisualStyleBackColor = true;
            this.rbEngineAuto.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // rbEngineRA2
            // 
            this.rbEngineRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineRA2.AutoSize = true;
            this.rbEngineRA2.Location = new System.Drawing.Point(196, 22);
            this.rbEngineRA2.Name = "rbEngineRA2";
            this.rbEngineRA2.Size = new System.Drawing.Size(76, 17);
            this.rbEngineRA2.TabIndex = 20;
            this.rbEngineRA2.TabStop = true;
            this.rbEngineRA2.Text = "Force RA2";
            this.rbEngineRA2.UseVisualStyleBackColor = true;
            this.rbEngineRA2.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // rbEngineYR
            // 
            this.rbEngineYR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineYR.AutoSize = true;
            this.rbEngineYR.Location = new System.Drawing.Point(102, 22);
            this.rbEngineYR.Name = "rbEngineYR";
            this.rbEngineYR.Size = new System.Drawing.Size(70, 17);
            this.rbEngineYR.TabIndex = 19;
            this.rbEngineYR.TabStop = true;
            this.rbEngineYR.Text = "Force YR";
            this.rbEngineYR.UseVisualStyleBackColor = true;
            this.rbEngineYR.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // lbEngine
            // 
            this.lbEngine.Location = new System.Drawing.Point(12, 2);
            this.lbEngine.Name = "lbEngine";
            this.lbEngine.Size = new System.Drawing.Size(487, 16);
            this.lbEngine.TabIndex = 40;
            this.lbEngine.Text = "This setting tells the program which engine to mimic. Picking an incompatible one" +
    " will cause crashes.";
            // 
            // tbMixDir
            // 
            this.tbMixDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMixDir.Location = new System.Drawing.Point(124, 44);
            this.tbMixDir.Name = "tbMixDir";
            this.tbMixDir.Size = new System.Drawing.Size(370, 20);
            this.tbMixDir.TabIndex = 4;
            this.tbMixDir.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // lblMixFiles
            // 
            this.lblMixFiles.AutoSize = true;
            this.lblMixFiles.Location = new System.Drawing.Point(16, 45);
            this.lblMixFiles.Name = "lblMixFiles";
            this.lblMixFiles.Size = new System.Drawing.Size(44, 13);
            this.lblMixFiles.TabIndex = 0;
            this.lblMixFiles.Text = "Mix files";
            this.toolTip.SetToolTip(this.lblMixFiles, "Set this to the folder where you have your game mix files stored.\r\nIf possible, t" +
        "his will be determined from information in the registry,\r\nmeaning you can leave " +
        "this empty.");
            // 
            // btnBrowseMixDir
            // 
            this.btnBrowseMixDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMixDir.Location = new System.Drawing.Point(500, 44);
            this.btnBrowseMixDir.Name = "btnBrowseMixDir";
            this.btnBrowseMixDir.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseMixDir.TabIndex = 5;
            this.btnBrowseMixDir.Text = "Browse";
            this.btnBrowseMixDir.UseVisualStyleBackColor = true;
            this.btnBrowseMixDir.Click += new System.EventHandler(this.BrowseMixDir);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(124, 18);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(370, 20);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // lblInputMap
            // 
            this.lblInputMap.AutoSize = true;
            this.lblInputMap.Location = new System.Drawing.Point(16, 21);
            this.lblInputMap.Name = "lblInputMap";
            this.lblInputMap.Size = new System.Drawing.Size(54, 13);
            this.lblInputMap.TabIndex = 0;
            this.lblInputMap.Text = "Input map";
            this.toolTip.SetToolTip(this.lblInputMap, "Full path the to input map.\r\nValid filetypes are *.mpr, *.map, *.yrm, *.mmx, *.yr" +
        "o.");
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInput.Location = new System.Drawing.Point(500, 18);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.BrowseInput);
            // 
            // btnRenderExecute
            // 
            this.btnRenderExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenderExecute.Location = new System.Drawing.Point(501, 281);
            this.btnRenderExecute.Name = "btnRenderExecute";
            this.btnRenderExecute.Size = new System.Drawing.Size(75, 23);
            this.btnRenderExecute.TabIndex = 32;
            this.btnRenderExecute.Text = "Render map";
            this.btnRenderExecute.UseVisualStyleBackColor = true;
            this.btnRenderExecute.Click += new System.EventHandler(this.ExecuteCommand);
            // 
            // tbCommandPreview
            // 
            this.tbCommandPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandPreview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbCommandPreview.Location = new System.Drawing.Point(73, 281);
            this.tbCommandPreview.Multiline = true;
            this.tbCommandPreview.Name = "tbCommandPreview";
            this.tbCommandPreview.ReadOnly = true;
            this.tbCommandPreview.Size = new System.Drawing.Size(423, 52);
            this.tbCommandPreview.TabIndex = 30;
            this.toolTip.SetToolTip(this.tbCommandPreview, "For more fine-grained control you can invoke CNCMaps.Renderer.exe manually!");
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblFill,
            this.pbProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 383);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(606, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Status:";
            // 
            // lblFill
            // 
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(447, 17);
            this.lblFill.Spring = true;
            // 
            // pbProgress
            // 
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 16);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Map list";
            this.toolTip.SetToolTip(this.label6, "Full paths the to input maps.\r\nValid filetypes are *.mpr, *.map, *.yrm, *.mmx, *." +
        "yro.");
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpMain);
            this.tabControl.Controls.Add(this.tpMisc);
            this.tabControl.Controls.Add(this.tpBatch);
            this.tabControl.Controls.Add(this.tpLog);
            this.tabControl.Controls.Add(this.tpAbout);
            this.tabControl.Location = new System.Drawing.Point(3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(603, 365);
            this.tabControl.TabIndex = 8;
            this.tabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.tabControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.lblCommand);
            this.tpMain.Controls.Add(this.gbInputOutput);
            this.tpMain.Controls.Add(this.btnRenderExecute);
            this.tpMain.Controls.Add(this.tbCommandPreview);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(595, 339);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main settings";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // lblCommand
            // 
            this.lblCommand.Location = new System.Drawing.Point(13, 281);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(54, 21);
            this.lblCommand.TabIndex = 0;
            this.lblCommand.Text = "Command";
            // 
            // tpMisc
            // 
            this.tpMisc.Controls.Add(this.gbMiscOptions);
            this.tpMisc.Location = new System.Drawing.Point(4, 22);
            this.tpMisc.Name = "tpMisc";
            this.tpMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tpMisc.Size = new System.Drawing.Size(595, 339);
            this.tpMisc.TabIndex = 1;
            this.tpMisc.Text = "Misc settings";
            this.tpMisc.UseVisualStyleBackColor = true;
            // 
            // tpBatch
            // 
            this.tpBatch.Controls.Add(this.gbBatchRender);
            this.tpBatch.Location = new System.Drawing.Point(4, 22);
            this.tpBatch.Name = "tpBatch";
            this.tpBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tpBatch.Size = new System.Drawing.Size(595, 339);
            this.tpBatch.TabIndex = 4;
            this.tpBatch.Text = "Batch render";
            this.tpBatch.UseVisualStyleBackColor = true;
            // 
            // gbBatchRender
            // 
            this.gbBatchRender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBatchRender.Controls.Add(this.btnBatchRender);
            this.gbBatchRender.Controls.Add(this.btnClearList);
            this.gbBatchRender.Controls.Add(this.label2);
            this.gbBatchRender.Controls.Add(this.tbBatchInput);
            this.gbBatchRender.Controls.Add(this.label6);
            this.gbBatchRender.Controls.Add(this.btnBrowseMaps);
            this.gbBatchRender.Location = new System.Drawing.Point(6, 6);
            this.gbBatchRender.Name = "gbBatchRender";
            this.gbBatchRender.Size = new System.Drawing.Size(582, 327);
            this.gbBatchRender.TabIndex = 1;
            this.gbBatchRender.TabStop = false;
            this.gbBatchRender.Text = "Batch map render";
            this.gbBatchRender.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.gbBatchRender.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // btnBatchRender
            // 
            this.btnBatchRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchRender.Location = new System.Drawing.Point(420, 298);
            this.btnBatchRender.Name = "btnBatchRender";
            this.btnBatchRender.Size = new System.Drawing.Size(156, 23);
            this.btnBatchRender.TabIndex = 33;
            this.btnBatchRender.Text = "Start batch rendering";
            this.btnBatchRender.UseVisualStyleBackColor = true;
            this.btnBatchRender.Click += new System.EventHandler(this.BtnBatchRender_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(501, 71);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 21);
            this.btnClearList.TabIndex = 4;
            this.btnClearList.Text = "Clear list";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tbBatchInput
            // 
            this.tbBatchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBatchInput.Location = new System.Drawing.Point(13, 98);
            this.tbBatchInput.Multiline = true;
            this.tbBatchInput.Name = "tbBatchInput";
            this.tbBatchInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBatchInput.Size = new System.Drawing.Size(563, 194);
            this.tbBatchInput.TabIndex = 1;
            // 
            // btnBrowseMaps
            // 
            this.btnBrowseMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMaps.Location = new System.Drawing.Point(420, 71);
            this.btnBrowseMaps.Name = "btnBrowseMaps";
            this.btnBrowseMaps.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseMaps.TabIndex = 2;
            this.btnBrowseMaps.Text = "Add maps";
            this.btnBrowseMaps.UseVisualStyleBackColor = true;
            this.btnBrowseMaps.Click += new System.EventHandler(this.BtnAddMaps_Click);
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.btnClearLog);
            this.tpLog.Controls.Add(this.gbLog);
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Size = new System.Drawing.Size(595, 339);
            this.tpLog.TabIndex = 2;
            this.tpLog.Text = "Log";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(517, 309);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(64, 22);
            this.btnClearLog.TabIndex = 8;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.rtbLog);
            this.gbLog.Location = new System.Drawing.Point(6, 6);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(581, 330);
            this.gbLog.TabIndex = 7;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.Location = new System.Drawing.Point(6, 18);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbLog.Size = new System.Drawing.Size(569, 283);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            this.rtbLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLog_LinkClicked);
            // 
            // tpAbout
            // 
            this.tpAbout.AllowDrop = true;
            this.tpAbout.Controls.Add(this.label1);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(595, 339);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program by Frank Razenberg © 2005-2016\r\n\r\nSpecial thanks to Olaf van der Spek for" +
    " XCC.\r\nSpecial thanks to #renproj for modenc.";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 405);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(582, 372);
            this.Name = "MainForm";
            this.Text = "Red Alert 2 and Tiberian Sun map renderer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            this.gbMiscOptions.ResumeLayout(false);
            this.gbOreGems.ResumeLayout(false);
            this.gbOreGems.PerformLayout();
            this.gbStartMarkers.ResumeLayout(false);
            this.gbStartMarkers.PerformLayout();
            this.gbModify.ResumeLayout(false);
            this.gbModify.PerformLayout();
            this.gbSizeMode.ResumeLayout(false);
            this.gbSizeMode.PerformLayout();
            this.gbThumbs.ResumeLayout(false);
            this.gbThumbs.PerformLayout();
            this.gbAdditionals.ResumeLayout(false);
            this.gbAdditionals.PerformLayout();
            this.gbInputOutput.ResumeLayout(false);
            this.gbInputOutput.PerformLayout();
            this.gbModConfig.ResumeLayout(false);
            this.gbModConfig.PerformLayout();
            this.gbFilename.ResumeLayout(false);
            this.gbFilename.PerformLayout();
            this.gbImageFormat.ResumeLayout(false);
            this.gbImageFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncodingQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).EndInit();
            this.pnlEngine.ResumeLayout(false);
            this.pnlEngine.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.tpMisc.ResumeLayout(false);
            this.tpBatch.ResumeLayout(false);
            this.gbBatchRender.ResumeLayout(false);
            this.gbBatchRender.PerformLayout();
            this.tpLog.ResumeLayout(false);
            this.gbLog.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbMiscOptions;
		private System.Windows.Forms.CheckBox cbEmphasizeOre;
		private System.Windows.Forms.Label lblOreEmphasisDescription;
		private System.Windows.Forms.GroupBox gbInputOutput;
		private System.Windows.Forms.Button btnBrowseInput;
		private System.Windows.Forms.TextBox tbMixDir;
		private System.Windows.Forms.Label lblMixFiles;
		private System.Windows.Forms.Button btnBrowseMixDir;
		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.Label lblInputMap;
		private System.Windows.Forms.Button btnRenderExecute;
		private System.Windows.Forms.TextBox tbCommandPreview;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox tbCustomOutput;
		private System.Windows.Forms.RadioButton rbCustomFilename;
		private System.Windows.Forms.RadioButton rbAutoFilename;
		private System.Windows.Forms.Label lblQuality;
		private System.Windows.Forms.Label lblCompressionLevel;
		private System.Windows.Forms.NumericUpDown nudEncodingQuality;
		private System.Windows.Forms.CheckBox cbOutputJPG;
		private System.Windows.Forms.CheckBox cbOutputPNG;
		private System.Windows.Forms.NumericUpDown nudCompression;
		private System.Windows.Forms.RadioButton rbSizeLocal;
		private System.Windows.Forms.RadioButton rbSizeFullmap;
		private System.Windows.Forms.CheckBox cbReplacePreview;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblFill;
		private System.Windows.Forms.ToolStripProgressBar pbProgress;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.TextBox tbModConfig;
		private System.Windows.Forms.CheckBox cbModConfig;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnModEditor;
		private System.Windows.Forms.TabPage tpMisc;
		private System.Windows.Forms.TabPage tpMain;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.RadioButton rbSizeAuto;
		private System.Windows.Forms.Label lblCommand;
		private System.Windows.Forms.GroupBox gbThumbs;
		private System.Windows.Forms.GroupBox gbAdditionals;
		private CheckBox cbOutputThumbnail;
		private TextBox tbThumbDimensions;
		private CheckBox cbPreserveThumbAspect;
		private TabPage tpLog;
		private GroupBox gbLog;
		private RichTextBox rtbLog;
		private TabPage tpAbout;
		private ComboBox cbMarkersType;
		private Label lblMarkersType;
		private Label label1;
		private CheckBox ckbFixupTiles;
		private GroupBox gbSizeMode;
        private CheckBox cbThumbPNG;
        private RadioButton rbUseFilename;
        private CheckBox cbDiagnosticWindow;
        private CheckBox cbMarkIceGrowth;
        private CheckBox cbBackup;
        private CheckBox cbCompressTiles;
        private CheckBox cbFixOverlay;
        private CheckBox cbTunnelPaths;
        private GroupBox gbModify;
        private CheckBox cbTunnelPosition;
        private Panel pnlEngine;
        private RadioButton rbEngineFS;
        private RadioButton rbEngineTS;
        private RadioButton rbEngineAuto;
        private RadioButton rbEngineRA2;
        private RadioButton rbEngineYR;
        private Label lbEngine;
        private GroupBox gbModConfig;
        private GroupBox gbFilename;
        private GroupBox gbImageFormat;
        private Button btnClearLog;
        private GroupBox gbStartMarkers;
        private Label lblMarkerSize;
        private Label lblStartMarkerType;
        private ComboBox cmbMarkerSize;
        private ComboBox cmbStartMarkers;
        private Label lblSquaredStartPosDescription;
        private CheckBox cbStartMarkers;
        private GroupBox gbOreGems;
        private TabPage tpBatch;
        private GroupBox gbBatchRender;
        private Label label2;
        private TextBox tbBatchInput;
        private Label label6;
        private Button btnBrowseMaps;
        private Button btnClearList;
        private Button btnBatchRender;
    }
}

