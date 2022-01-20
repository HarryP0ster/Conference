
namespace RSI_X_Desktop.forms
{
    partial class PopUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpForm));
            this.tablepanel = new DevExpress.Utils.Layout.TablePanel();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TableGeneral = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.resComboBox = new RSI_X_Desktop.forms.HelpingClass.newAloneComboBox();
            this.ResLabel = new ReaLTaiizor.Controls.DungeonLabel();
            this.tablePanel7 = new DevExpress.Utils.Layout.TablePanel();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.pictureBoxLocalVideoTest = new ReaLTaiizor.Controls.HopePictureBox();
            this.btnCustomImage = new ReaLTaiizor.Controls.BigLabel();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.comboBoxVideo = new RSI_X_Desktop.forms.HelpingClass.newAloneComboBox();
            this.CameraLabel = new ReaLTaiizor.Controls.DungeonLabel();
            this.SpeakerLabel = new ReaLTaiizor.Controls.DungeonLabel();
            this.VolumeSpeakLabel = new ReaLTaiizor.Controls.BigLabel();
            this.trackBarSoundOut = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.comboBoxAudioOutput = new RSI_X_Desktop.forms.HelpingClass.newAloneComboBox();
            this.testSpeaker = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.comboBoxAudioInput = new RSI_X_Desktop.forms.HelpingClass.newAloneComboBox();
            this.testMic = new ReaLTaiizor.Controls.BigLabel();
            this.VolumeMicLabel = new ReaLTaiizor.Controls.BigLabel();
            this.MicrophoneLabel = new ReaLTaiizor.Controls.DungeonLabel();
            this.trackBarSoundIn = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.TableMisc = new DevExpress.Utils.Layout.TablePanel();
            this.labelAudioQuality = new ReaLTaiizor.Controls.DungeonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AudioQualityCmb = new RSI_X_Desktop.forms.HelpingClass.newAloneComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelGeneral = new System.Windows.Forms.Label();
            this.LabelMisc = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.ApplyBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.ConfirmBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.CancelBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.BCloseGeneral = new ReaLTaiizor.Controls.Button();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tablepanel)).BeginInit();
            this.tablepanel.SuspendLayout();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGeneral)).BeginInit();
            this.TableGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel7)).BeginInit();
            this.tablePanel7.SuspendLayout();
            this.PreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableMisc)).BeginInit();
            this.TableMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablepanel
            // 
            this.tablepanel.Appearance.BackColor = System.Drawing.Color.White;
            this.tablepanel.Appearance.Options.UseBackColor = true;
            this.tablepanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablepanel.Controls.Add(this.MainLayout);
            this.tablepanel.Controls.Add(this.tableLayoutPanel1);
            this.tablepanel.Controls.Add(this.tablePanel1);
            this.tablepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablepanel.Location = new System.Drawing.Point(0, 0);
            this.tablepanel.Name = "tablepanel";
            this.tablepanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.tablepanel.Size = new System.Drawing.Size(525, 600);
            this.tablepanel.TabIndex = 1;
            // 
            // MainLayout
            // 
            this.tablepanel.SetColumn(this.MainLayout, 1);
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.TableGeneral, 0, 0);
            this.MainLayout.Controls.Add(this.TableMisc, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(25, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayout.Name = "MainLayout";
            this.tablepanel.SetRow(this.MainLayout, 0);
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Size = new System.Drawing.Size(500, 510);
            this.MainLayout.TabIndex = 3;
            // 
            // TableGeneral
            // 
            this.TableGeneral.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F)});
            this.TableGeneral.Controls.Add(this.tablePanel3);
            this.TableGeneral.Controls.Add(this.ResLabel);
            this.TableGeneral.Controls.Add(this.tablePanel7);
            this.TableGeneral.Controls.Add(this.tablePanel6);
            this.TableGeneral.Controls.Add(this.CameraLabel);
            this.TableGeneral.Controls.Add(this.SpeakerLabel);
            this.TableGeneral.Controls.Add(this.VolumeSpeakLabel);
            this.TableGeneral.Controls.Add(this.trackBarSoundOut);
            this.TableGeneral.Controls.Add(this.tablePanel5);
            this.TableGeneral.Controls.Add(this.pictureBox1);
            this.TableGeneral.Controls.Add(this.tablePanel4);
            this.TableGeneral.Controls.Add(this.VolumeMicLabel);
            this.TableGeneral.Controls.Add(this.MicrophoneLabel);
            this.TableGeneral.Controls.Add(this.trackBarSoundIn);
            this.TableGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableGeneral.Location = new System.Drawing.Point(0, 0);
            this.TableGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TableGeneral.Name = "TableGeneral";
            this.TableGeneral.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F)});
            this.TableGeneral.Size = new System.Drawing.Size(250, 510);
            this.TableGeneral.TabIndex = 1;
            // 
            // tablePanel3
            // 
            this.TableGeneral.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel3.Controls.Add(this.resComboBox);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(66, 297);
            this.tablePanel3.Name = "tablePanel3";
            this.TableGeneral.SetRow(this.tablePanel3, 6);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(182, 43);
            this.tablePanel3.TabIndex = 18;
            // 
            // resComboBox
            // 
            this.resComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel3.SetColumn(this.resComboBox, 0);
            this.resComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resComboBox.EnabledCalc = true;
            this.resComboBox.FormattingEnabled = true;
            this.resComboBox.ItemHeight = 20;
            this.resComboBox.Location = new System.Drawing.Point(2, 8);
            this.resComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resComboBox.Name = "resComboBox";
            this.tablePanel3.SetRow(this.resComboBox, 0);
            this.resComboBox.Size = new System.Drawing.Size(133, 26);
            this.resComboBox.TabIndex = 10;
            this.resComboBox.SelectedIndexChanged += new System.EventHandler(this.resComboBox_SelectedIndexChanged);
            // 
            // ResLabel
            // 
            this.ResLabel.AutoSize = true;
            this.ResLabel.BackColor = System.Drawing.Color.Transparent;
            this.TableGeneral.SetColumn(this.ResLabel, 0);
            this.ResLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResLabel.ForeColor = System.Drawing.Color.Gray;
            this.ResLabel.Location = new System.Drawing.Point(3, 294);
            this.ResLabel.Name = "ResLabel";
            this.TableGeneral.SetRow(this.ResLabel, 6);
            this.ResLabel.Size = new System.Drawing.Size(57, 49);
            this.ResLabel.TabIndex = 17;
            this.ResLabel.Text = "Resolution";
            this.ResLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel7
            // 
            this.TableGeneral.SetColumn(this.tablePanel7, 1);
            this.tablePanel7.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F)});
            this.tablePanel7.Controls.Add(this.PreviewPanel);
            this.tablePanel7.Controls.Add(this.btnCustomImage);
            this.tablePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel7.Location = new System.Drawing.Point(66, 346);
            this.tablePanel7.Name = "tablePanel7";
            this.TableGeneral.SetRow(this.tablePanel7, 7);
            this.tablePanel7.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel7.Size = new System.Drawing.Size(182, 161);
            this.tablePanel7.TabIndex = 16;
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel7.SetColumn(this.PreviewPanel, 1);
            this.PreviewPanel.Controls.Add(this.pictureBoxLocalVideoTest);
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(19, 0);
            this.PreviewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PreviewPanel.Name = "PreviewPanel";
            this.tablePanel7.SetRow(this.PreviewPanel, 0);
            this.PreviewPanel.Size = new System.Drawing.Size(105, 121);
            this.PreviewPanel.TabIndex = 4;
            // 
            // pictureBoxLocalVideoTest
            // 
            this.pictureBoxLocalVideoTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.pictureBoxLocalVideoTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLocalVideoTest.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLocalVideoTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLocalVideoTest.Name = "pictureBoxLocalVideoTest";
            this.pictureBoxLocalVideoTest.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pictureBoxLocalVideoTest.Size = new System.Drawing.Size(105, 121);
            this.pictureBoxLocalVideoTest.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pictureBoxLocalVideoTest.TabIndex = 2;
            this.pictureBoxLocalVideoTest.TabStop = false;
            this.pictureBoxLocalVideoTest.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnCustomImage
            // 
            this.btnCustomImage.AutoSize = true;
            this.btnCustomImage.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel7.SetColumn(this.btnCustomImage, 1);
            this.btnCustomImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomImage.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnCustomImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.btnCustomImage.Location = new System.Drawing.Point(22, 121);
            this.btnCustomImage.Name = "btnCustomImage";
            this.tablePanel7.SetRow(this.btnCustomImage, 1);
            this.btnCustomImage.Size = new System.Drawing.Size(99, 40);
            this.btnCustomImage.TabIndex = 3;
            this.btnCustomImage.Text = "Custom image";
            this.btnCustomImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomImage.Click += new System.EventHandler(this.buttonImgSend_Click);
            // 
            // tablePanel6
            // 
            this.TableGeneral.SetColumn(this.tablePanel6, 1);
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel6.Controls.Add(this.comboBoxVideo);
            this.tablePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel6.Location = new System.Drawing.Point(66, 248);
            this.tablePanel6.Name = "tablePanel6";
            this.TableGeneral.SetRow(this.tablePanel6, 5);
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel6.Size = new System.Drawing.Size(182, 43);
            this.tablePanel6.TabIndex = 15;
            // 
            // comboBoxVideo
            // 
            this.comboBoxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel6.SetColumn(this.comboBoxVideo, 0);
            this.comboBoxVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxVideo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideo.EnabledCalc = true;
            this.comboBoxVideo.FormattingEnabled = true;
            this.comboBoxVideo.ItemHeight = 20;
            this.comboBoxVideo.Location = new System.Drawing.Point(2, 8);
            this.comboBoxVideo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxVideo.Name = "comboBoxVideo";
            this.tablePanel6.SetRow(this.comboBoxVideo, 0);
            this.comboBoxVideo.Size = new System.Drawing.Size(133, 26);
            this.comboBoxVideo.TabIndex = 1;
            this.comboBoxVideo.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideo_SelectedIndexChanged);
            // 
            // CameraLabel
            // 
            this.CameraLabel.AutoSize = true;
            this.CameraLabel.BackColor = System.Drawing.Color.Transparent;
            this.TableGeneral.SetColumn(this.CameraLabel, 0);
            this.CameraLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CameraLabel.ForeColor = System.Drawing.Color.Gray;
            this.CameraLabel.Location = new System.Drawing.Point(2, 245);
            this.CameraLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CameraLabel.Name = "CameraLabel";
            this.TableGeneral.SetRow(this.CameraLabel, 5);
            this.CameraLabel.Size = new System.Drawing.Size(59, 49);
            this.CameraLabel.TabIndex = 14;
            this.CameraLabel.Text = "Camera";
            this.CameraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeakerLabel
            // 
            this.SpeakerLabel.AutoSize = true;
            this.SpeakerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TableGeneral.SetColumn(this.SpeakerLabel, 0);
            this.SpeakerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeakerLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeakerLabel.ForeColor = System.Drawing.Color.Gray;
            this.SpeakerLabel.Location = new System.Drawing.Point(2, 147);
            this.SpeakerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpeakerLabel.Name = "SpeakerLabel";
            this.TableGeneral.SetRow(this.SpeakerLabel, 3);
            this.SpeakerLabel.Size = new System.Drawing.Size(59, 49);
            this.SpeakerLabel.TabIndex = 13;
            this.SpeakerLabel.Text = "Audio output";
            this.SpeakerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeSpeakLabel
            // 
            this.VolumeSpeakLabel.AutoSize = true;
            this.VolumeSpeakLabel.BackColor = System.Drawing.Color.Transparent;
            this.TableGeneral.SetColumn(this.VolumeSpeakLabel, 0);
            this.VolumeSpeakLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolumeSpeakLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeSpeakLabel.ForeColor = System.Drawing.Color.Black;
            this.VolumeSpeakLabel.Location = new System.Drawing.Point(2, 196);
            this.VolumeSpeakLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VolumeSpeakLabel.Name = "VolumeSpeakLabel";
            this.TableGeneral.SetRow(this.VolumeSpeakLabel, 4);
            this.VolumeSpeakLabel.Size = new System.Drawing.Size(59, 49);
            this.VolumeSpeakLabel.TabIndex = 12;
            this.VolumeSpeakLabel.Text = "Volume";
            this.VolumeSpeakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSoundOut
            // 
            this.trackBarSoundOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSoundOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarSoundOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TableGeneral.SetColumn(this.trackBarSoundOut, 1);
            this.trackBarSoundOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundOut.DrawValueString = false;
            this.trackBarSoundOut.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundOut.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundOut.JumpToMouse = true;
            this.trackBarSoundOut.Location = new System.Drawing.Point(65, 209);
            this.trackBarSoundOut.Margin = new System.Windows.Forms.Padding(2, 3, 45, 3);
            this.trackBarSoundOut.Maximum = 100;
            this.trackBarSoundOut.Minimum = 0;
            this.trackBarSoundOut.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundOut.Name = "trackBarSoundOut";
            this.TableGeneral.SetRow(this.trackBarSoundOut, 4);
            this.trackBarSoundOut.Size = new System.Drawing.Size(141, 22);
            this.trackBarSoundOut.TabIndex = 11;
            this.trackBarSoundOut.Text = "dungeonTrackBar1";
            this.trackBarSoundOut.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundOut.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundOut.Value = 100;
            this.trackBarSoundOut.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By100;
            this.trackBarSoundOut.ValueToSet = 1F;
            this.trackBarSoundOut.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBarSoundOut_ValueChanged);
            // 
            // tablePanel5
            // 
            this.TableGeneral.SetColumn(this.tablePanel5, 1);
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel5.Controls.Add(this.comboBoxAudioOutput);
            this.tablePanel5.Controls.Add(this.testSpeaker);
            this.tablePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel5.Location = new System.Drawing.Point(66, 150);
            this.tablePanel5.Name = "tablePanel5";
            this.TableGeneral.SetRow(this.tablePanel5, 3);
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel5.Size = new System.Drawing.Size(182, 43);
            this.tablePanel5.TabIndex = 10;
            // 
            // comboBoxAudioOutput
            // 
            this.comboBoxAudioOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel5.SetColumn(this.comboBoxAudioOutput, 0);
            this.comboBoxAudioOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioOutput.EnabledCalc = true;
            this.comboBoxAudioOutput.FormattingEnabled = true;
            this.comboBoxAudioOutput.ItemHeight = 20;
            this.comboBoxAudioOutput.Location = new System.Drawing.Point(2, 8);
            this.comboBoxAudioOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioOutput.Name = "comboBoxAudioOutput";
            this.tablePanel5.SetRow(this.comboBoxAudioOutput, 0);
            this.comboBoxAudioOutput.Size = new System.Drawing.Size(133, 26);
            this.comboBoxAudioOutput.TabIndex = 4;
            this.comboBoxAudioOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioOutput_SelectedIndexChanged);
            // 
            // testSpeaker
            // 
            this.testSpeaker.AutoSize = true;
            this.testSpeaker.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel5.SetColumn(this.testSpeaker, 1);
            this.testSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testSpeaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSpeaker.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.testSpeaker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.testSpeaker.Location = new System.Drawing.Point(139, 0);
            this.testSpeaker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testSpeaker.Name = "testSpeaker";
            this.tablePanel5.SetRow(this.testSpeaker, 0);
            this.testSpeaker.Size = new System.Drawing.Size(42, 43);
            this.testSpeaker.TabIndex = 3;
            this.testSpeaker.Text = "Test!";
            this.testSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.testSpeaker.Click += new System.EventHandler(this.SpeakerTestBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TableGeneral.SetColumn(this.pictureBox1, 0);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RSI_X_Desktop.Properties.Resources.logotype_compressed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.TableGeneral.SetRow(this.pictureBox1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(63, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tablePanel4
            // 
            this.TableGeneral.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel4.Controls.Add(this.comboBoxAudioInput);
            this.tablePanel4.Controls.Add(this.testMic);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(66, 52);
            this.tablePanel4.Name = "tablePanel4";
            this.TableGeneral.SetRow(this.tablePanel4, 1);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(182, 43);
            this.tablePanel4.TabIndex = 8;
            // 
            // comboBoxAudioInput
            // 
            this.comboBoxAudioInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel4.SetColumn(this.comboBoxAudioInput, 0);
            this.comboBoxAudioInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioInput.EnabledCalc = true;
            this.comboBoxAudioInput.FormattingEnabled = true;
            this.comboBoxAudioInput.ItemHeight = 20;
            this.comboBoxAudioInput.Location = new System.Drawing.Point(2, 8);
            this.comboBoxAudioInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioInput.Name = "comboBoxAudioInput";
            this.tablePanel4.SetRow(this.comboBoxAudioInput, 0);
            this.comboBoxAudioInput.Size = new System.Drawing.Size(133, 26);
            this.comboBoxAudioInput.TabIndex = 3;
            this.comboBoxAudioInput.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioInput_SelectedIndexChanged);
            // 
            // testMic
            // 
            this.testMic.AutoSize = true;
            this.testMic.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel4.SetColumn(this.testMic, 1);
            this.testMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testMic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testMic.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.testMic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.testMic.Location = new System.Drawing.Point(139, 0);
            this.testMic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testMic.Name = "testMic";
            this.tablePanel4.SetRow(this.testMic, 0);
            this.testMic.Size = new System.Drawing.Size(42, 43);
            this.testMic.TabIndex = 2;
            this.testMic.Text = "Test!";
            this.testMic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.testMic.Click += new System.EventHandler(this.MicTestClicked);
            // 
            // VolumeMicLabel
            // 
            this.VolumeMicLabel.AutoSize = true;
            this.VolumeMicLabel.BackColor = System.Drawing.Color.Transparent;
            this.TableGeneral.SetColumn(this.VolumeMicLabel, 0);
            this.VolumeMicLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolumeMicLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeMicLabel.ForeColor = System.Drawing.Color.Black;
            this.VolumeMicLabel.Location = new System.Drawing.Point(2, 98);
            this.VolumeMicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VolumeMicLabel.Name = "VolumeMicLabel";
            this.TableGeneral.SetRow(this.VolumeMicLabel, 2);
            this.VolumeMicLabel.Size = new System.Drawing.Size(59, 49);
            this.VolumeMicLabel.TabIndex = 7;
            this.VolumeMicLabel.Text = "Volume";
            this.VolumeMicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MicrophoneLabel
            // 
            this.MicrophoneLabel.AutoSize = true;
            this.MicrophoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.TableGeneral.SetColumn(this.MicrophoneLabel, 0);
            this.MicrophoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MicrophoneLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MicrophoneLabel.ForeColor = System.Drawing.Color.Gray;
            this.MicrophoneLabel.Location = new System.Drawing.Point(2, 49);
            this.MicrophoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MicrophoneLabel.Name = "MicrophoneLabel";
            this.TableGeneral.SetRow(this.MicrophoneLabel, 1);
            this.MicrophoneLabel.Size = new System.Drawing.Size(59, 49);
            this.MicrophoneLabel.TabIndex = 6;
            this.MicrophoneLabel.Text = "Audio input";
            this.MicrophoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSoundIn
            // 
            this.trackBarSoundIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSoundIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarSoundIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TableGeneral.SetColumn(this.trackBarSoundIn, 1);
            this.trackBarSoundIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundIn.DrawValueString = false;
            this.trackBarSoundIn.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundIn.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundIn.JumpToMouse = true;
            this.trackBarSoundIn.Location = new System.Drawing.Point(65, 111);
            this.trackBarSoundIn.Margin = new System.Windows.Forms.Padding(2, 3, 45, 3);
            this.trackBarSoundIn.Maximum = 100;
            this.trackBarSoundIn.Minimum = 0;
            this.trackBarSoundIn.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundIn.Name = "trackBarSoundIn";
            this.TableGeneral.SetRow(this.trackBarSoundIn, 2);
            this.trackBarSoundIn.Size = new System.Drawing.Size(141, 22);
            this.trackBarSoundIn.TabIndex = 4;
            this.trackBarSoundIn.Text = "dungeonTrackBar1";
            this.trackBarSoundIn.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundIn.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundIn.Value = 100;
            this.trackBarSoundIn.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By100;
            this.trackBarSoundIn.ValueToSet = 1F;
            this.trackBarSoundIn.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBarSoundIn_ValueChanged);
            // 
            // TableMisc
            // 
            this.TableMisc.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.TableMisc.Controls.Add(this.labelAudioQuality);
            this.TableMisc.Controls.Add(this.pictureBox2);
            this.TableMisc.Controls.Add(this.AudioQualityCmb);
            this.TableMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMisc.Location = new System.Drawing.Point(260, 0);
            this.TableMisc.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TableMisc.Name = "TableMisc";
            this.TableMisc.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F)});
            this.TableMisc.Size = new System.Drawing.Size(240, 510);
            this.TableMisc.TabIndex = 2;
            // 
            // labelAudioQuality
            // 
            this.labelAudioQuality.AutoSize = true;
            this.labelAudioQuality.BackColor = System.Drawing.Color.Transparent;
            this.TableMisc.SetColumn(this.labelAudioQuality, 0);
            this.labelAudioQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAudioQuality.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAudioQuality.ForeColor = System.Drawing.Color.Gray;
            this.labelAudioQuality.Location = new System.Drawing.Point(2, 77);
            this.labelAudioQuality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAudioQuality.Name = "labelAudioQuality";
            this.TableMisc.SetRow(this.labelAudioQuality, 1);
            this.labelAudioQuality.Size = new System.Drawing.Size(68, 51);
            this.labelAudioQuality.TabIndex = 12;
            this.labelAudioQuality.Text = "Audio input quality";
            this.labelAudioQuality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TableMisc.SetColumn(this.pictureBox2, 0);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::RSI_X_Desktop.Properties.Resources.logotype_compressed;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.TableMisc.SetRow(this.pictureBox2, 0);
            this.pictureBox2.Size = new System.Drawing.Size(66, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // AudioQualityCmb
            // 
            this.TableMisc.SetColumn(this.AudioQualityCmb, 1);
            this.AudioQualityCmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AudioQualityCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AudioQualityCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioQualityCmb.EnabledCalc = true;
            this.AudioQualityCmb.FormattingEnabled = true;
            this.AudioQualityCmb.ItemHeight = 20;
            this.AudioQualityCmb.Location = new System.Drawing.Point(75, 89);
            this.AudioQualityCmb.Name = "AudioQualityCmb";
            this.TableMisc.SetRow(this.AudioQualityCmb, 1);
            this.AudioQualityCmb.Size = new System.Drawing.Size(138, 26);
            this.AudioQualityCmb.TabIndex = 0;
            this.AudioQualityCmb.SelectedIndexChanged += new System.EventHandler(this.AudioQualityCmb_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tablepanel.SetColumn(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LabelGeneral, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelMisc, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tablepanel.SetRow(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(25, 510);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LabelGeneral
            // 
            this.LabelGeneral.AutoSize = true;
            this.LabelGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelGeneral.Location = new System.Drawing.Point(0, 0);
            this.LabelGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.LabelGeneral.Name = "LabelGeneral";
            this.LabelGeneral.Size = new System.Drawing.Size(25, 100);
            this.LabelGeneral.TabIndex = 0;
            this.LabelGeneral.Click += new System.EventHandler(this.LabelGeneral_Click);
            this.LabelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelGeneral_Paint);
            // 
            // LabelMisc
            // 
            this.LabelMisc.AutoSize = true;
            this.LabelMisc.BackColor = System.Drawing.Color.Gray;
            this.LabelMisc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMisc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelMisc.Location = new System.Drawing.Point(0, 100);
            this.LabelMisc.Margin = new System.Windows.Forms.Padding(0);
            this.LabelMisc.Name = "LabelMisc";
            this.LabelMisc.Size = new System.Drawing.Size(25, 100);
            this.LabelMisc.TabIndex = 1;
            this.LabelMisc.Click += new System.EventHandler(this.LabelMisc_Click);
            this.LabelMisc.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelMisc_Paint);
            // 
            // tablePanel1
            // 
            this.tablepanel.SetColumn(this.tablePanel1, 1);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.ApplyBtn);
            this.tablePanel1.Controls.Add(this.ConfirmBtn);
            this.tablePanel1.Controls.Add(this.CancelBtn);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(28, 513);
            this.tablePanel1.Name = "tablePanel1";
            this.tablepanel.SetRow(this.tablePanel1, 1);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(494, 84);
            this.tablePanel1.TabIndex = 0;
            // 
            // ApplyBtn
            // 
            this.tablePanel1.SetColumn(this.ApplyBtn, 3);
            this.ApplyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyBtn.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.ApplyBtn.ItemAppearance.Normal.BorderThickness = 1F;
            this.ApplyBtn.Location = new System.Drawing.Point(337, 5);
            this.ApplyBtn.Margin = new System.Windows.Forms.Padding(15, 5, 15, 25);
            this.ApplyBtn.Name = "ApplyBtn";
            this.tablePanel1.SetRow(this.ApplyBtn, 0);
            this.ApplyBtn.Size = new System.Drawing.Size(120, 54);
            this.ApplyBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ApplyBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ApplyBtn.SvgImage")));
            this.ApplyBtn.TabIndex = 2;
            this.ApplyBtn.Text = "svgImageBox3";
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyButton_Click);
            this.ApplyBtn.MouseLeave += new System.EventHandler(this.ApplyBtn_MouseLeave);
            this.ApplyBtn.MouseHover += new System.EventHandler(this.ApplyBtn_MouseHover);
            // 
            // ConfirmBtn
            // 
            this.tablePanel1.SetColumn(this.ConfirmBtn, 2);
            this.ConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfirmBtn.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.ConfirmBtn.ItemAppearance.Normal.BorderThickness = 1F;
            this.ConfirmBtn.Location = new System.Drawing.Point(187, 5);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(15, 5, 15, 25);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.tablePanel1.SetRow(this.ConfirmBtn, 0);
            this.ConfirmBtn.Size = new System.Drawing.Size(120, 54);
            this.ConfirmBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ConfirmBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ConfirmBtn.SvgImage")));
            this.ConfirmBtn.TabIndex = 1;
            this.ConfirmBtn.Text = "svgImageBox2";
            this.ConfirmBtn.Click += new System.EventHandler(this.AcceptButton_Click);
            this.ConfirmBtn.MouseLeave += new System.EventHandler(this.ConfirmBtn_MouseLeave);
            this.ConfirmBtn.MouseHover += new System.EventHandler(this.ConfirmBtn_MouseHover);
            // 
            // CancelBtn
            // 
            this.tablePanel1.SetColumn(this.CancelBtn, 1);
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.ItemAppearance.Normal.BorderThickness = 1F;
            this.CancelBtn.Location = new System.Drawing.Point(37, 5);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(15, 5, 15, 25);
            this.CancelBtn.Name = "CancelBtn";
            this.tablePanel1.SetRow(this.CancelBtn, 0);
            this.CancelBtn.Size = new System.Drawing.Size(120, 54);
            this.CancelBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.CancelBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CancelBtn.SvgImage")));
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "svgImageBox1";
            this.CancelBtn.Click += new System.EventHandler(this.CloseButton_Click);
            this.CancelBtn.MouseLeave += new System.EventHandler(this.CancelBtn_MouseLeave);
            this.CancelBtn.MouseHover += new System.EventHandler(this.CancelBtn_MouseHover);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 8);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 9;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.BCloseGeneral, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(194, 14);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // BCloseGeneral
            // 
            this.BCloseGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BCloseGeneral.BackColor = System.Drawing.Color.Transparent;
            this.BCloseGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCloseGeneral.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCloseGeneral.Image = null;
            this.BCloseGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCloseGeneral.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Location = new System.Drawing.Point(111, 3);
            this.BCloseGeneral.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseGeneral.Name = "BCloseGeneral";
            this.BCloseGeneral.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Size = new System.Drawing.Size(80, 1);
            this.BCloseGeneral.TabIndex = 6;
            this.BCloseGeneral.Text = "Close";
            this.BCloseGeneral.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(2, 0);
            this.bigLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(109, 29);
            this.bigLabel2.TabIndex = 0;
            this.bigLabel2.Text = "Your system";
            // 
            // PopUpForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(525, 600);
            this.Controls.Add(this.tablepanel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PopUpForm.IconOptions.Icon")));
            this.Name = "PopUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpForm";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDevices_FormClosed);
            this.Load += new System.EventHandler(this.NewDevices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablepanel)).EndInit();
            this.tablepanel.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableGeneral)).EndInit();
            this.TableGeneral.ResumeLayout(false);
            this.TableGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel7)).EndInit();
            this.tablePanel7.ResumeLayout(false);
            this.tablePanel7.PerformLayout();
            this.PreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            this.tablePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.tablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableMisc)).EndInit();
            this.TableMisc.ResumeLayout(false);
            this.TableMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApplyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablepanel;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SvgImageBox CancelBtn;
        private DevExpress.XtraEditors.SvgImageBox ConfirmBtn;
        private DevExpress.XtraEditors.SvgImageBox ApplyBtn;
        private DevExpress.Utils.Layout.TablePanel TableGeneral;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundIn;
        private ReaLTaiizor.Controls.DungeonLabel MicrophoneLabel;
        private ReaLTaiizor.Controls.BigLabel VolumeMicLabel;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private ReaLTaiizor.Controls.BigLabel testMic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.Button BCloseGeneral;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private ReaLTaiizor.Controls.DungeonLabel SpeakerLabel;
        private ReaLTaiizor.Controls.BigLabel VolumeSpeakLabel;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundOut;
        private ReaLTaiizor.Controls.BigLabel testSpeaker;
        private ReaLTaiizor.Controls.DungeonLabel CameraLabel;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private DevExpress.Utils.Layout.TablePanel tablePanel7;
        private ReaLTaiizor.Controls.HopePictureBox pictureBoxLocalVideoTest;
        private ReaLTaiizor.Controls.DungeonLabel ResLabel;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private ReaLTaiizor.Controls.BigLabel btnCustomImage;
        private System.Windows.Forms.Panel PreviewPanel;
        private RSI_X_Desktop.forms.HelpingClass.newAloneComboBox comboBoxAudioInput;
        private RSI_X_Desktop.forms.HelpingClass.newAloneComboBox comboBoxAudioOutput;
        private RSI_X_Desktop.forms.HelpingClass.newAloneComboBox comboBoxVideo;
        private RSI_X_Desktop.forms.HelpingClass.newAloneComboBox resComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelGeneral;
        private System.Windows.Forms.Label LabelMisc;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private DevExpress.Utils.Layout.TablePanel TableMisc;
        private HelpingClass.newAloneComboBox AudioQualityCmb;
        private ReaLTaiizor.Controls.DungeonLabel labelAudioQuality;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}