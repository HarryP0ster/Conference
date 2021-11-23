
namespace RSI_X_Desktop
{
    partial class Broadcaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Broadcaster));
            this.formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBot = new ReaLTaiizor.Controls.LostPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.labelChat = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelMicrophone = new System.Windows.Forms.Label();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelScreenShare = new System.Windows.Forms.Label();
            this.PanelTop = new ReaLTaiizor.Controls.LostPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new ReaLTaiizor.Controls.Button();
            this.SettingButton = new ReaLTaiizor.Controls.Button();
            this.ResetButton = new ReaLTaiizor.Controls.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoomNameLabel = new ReaLTaiizor.Controls.SkyLabel();
            this.StreamLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelNothing = new System.Windows.Forms.Panel();
            this.pictureBoxRemoteVideo = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.formTheme1.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.PanelBot.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StreamLayout.SuspendLayout();
            this.PanelNothing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoteVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // formTheme1
            // 
            this.formTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.formTheme1.Controls.Add(this.MainLayout);
            this.formTheme1.Controls.Add(this.nightControlBox1);
            this.formTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTheme1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.formTheme1.Location = new System.Drawing.Point(0, 0);
            this.formTheme1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.formTheme1.Name = "formTheme1";
            this.formTheme1.Padding = new System.Windows.Forms.Padding(0, 22, 0, 22);
            this.formTheme1.Sizable = false;
            this.formTheme1.Size = new System.Drawing.Size(1280, 800);
            this.formTheme1.SmartBounds = false;
            this.formTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.formTheme1.TabIndex = 10;
            this.formTheme1.Text = "RSI X DESKTOP BROADCASTER";
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.PanelBot, 0, 2);
            this.MainLayout.Controls.Add(this.PanelTop, 0, 0);
            this.MainLayout.Controls.Add(this.StreamLayout, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 22);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.Size = new System.Drawing.Size(1280, 756);
            this.MainLayout.TabIndex = 93;
            // 
            // PanelBot
            // 
            this.PanelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelBot.Controls.Add(this.tableLayoutPanel2);
            this.PanelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelBot.ForeColor = System.Drawing.Color.White;
            this.PanelBot.Location = new System.Drawing.Point(4, 682);
            this.PanelBot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelBot.Name = "PanelBot";
            this.PanelBot.Padding = new System.Windows.Forms.Padding(5);
            this.PanelBot.ShowText = true;
            this.PanelBot.Size = new System.Drawing.Size(1272, 71);
            this.PanelBot.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.trackBar1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelChat, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSettings, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelMicrophone, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelVideo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelVolume, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelScreenShare, 8, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1272, 71);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.trackBar1.BorderColor = System.Drawing.Color.White;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.DrawValueString = false;
            this.trackBar1.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBar1.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.trackBar1.JumpToMouse = true;
            this.trackBar1.Location = new System.Drawing.Point(482, 24);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 0;
            this.trackBar1.MinimumSize = new System.Drawing.Size(47, 22);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(77, 22);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Text = "dungeonTrackBar1";
            this.trackBar1.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBar1.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBar1.Value = 100;
            this.trackBar1.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.trackBar1.ValueToSet = 100F;
            this.trackBar1.Visible = false;
            // 
            // labelChat
            // 
            this.labelChat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChat.AutoSize = true;
            this.labelChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChat.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChat.Location = new System.Drawing.Point(1205, 17);
            this.labelChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(63, 36);
            this.labelChat.TabIndex = 15;
            this.labelChat.Text = "CHAT";
            this.labelChat.Click += new System.EventHandler(this.labelChat_Click);
            // 
            // labelSettings
            // 
            this.labelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSettings.AutoSize = true;
            this.labelSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSettings.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSettings.Location = new System.Drawing.Point(4, 17);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(107, 36);
            this.labelSettings.TabIndex = 16;
            this.labelSettings.Text = "SETTINGS";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSettings.Click += new System.EventHandler(this.labelSettings_Click);
            // 
            // labelMicrophone
            // 
            this.labelMicrophone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMicrophone.AutoSize = true;
            this.labelMicrophone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMicrophone.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMicrophone.Location = new System.Drawing.Point(119, 17);
            this.labelMicrophone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMicrophone.Name = "labelMicrophone";
            this.labelMicrophone.Size = new System.Drawing.Size(142, 36);
            this.labelMicrophone.TabIndex = 17;
            this.labelMicrophone.Text = "MICROPHONE";
            this.labelMicrophone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMicrophone.Click += new System.EventHandler(this.labelMicrophone_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVideo.AutoSize = true;
            this.labelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVideo.Location = new System.Drawing.Point(269, 17);
            this.labelVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(106, 36);
            this.labelVideo.TabIndex = 18;
            this.labelVideo.Text = "  CAMERA";
            this.labelVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVideo.Click += new System.EventHandler(this.labelVideo_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVolume.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume.Location = new System.Drawing.Point(383, 17);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(91, 36);
            this.labelVolume.TabIndex = 19;
            this.labelVolume.Text = "VOLUME";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVolume.Visible = false;
            this.labelVolume.Click += new System.EventHandler(this.labelVolume_Click);
            // 
            // labelScreenShare
            // 
            this.labelScreenShare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelScreenShare.AutoSize = true;
            this.labelScreenShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelScreenShare.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScreenShare.Location = new System.Drawing.Point(1037, 17);
            this.labelScreenShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScreenShare.Name = "labelScreenShare";
            this.labelScreenShare.Size = new System.Drawing.Size(159, 36);
            this.labelScreenShare.TabIndex = 20;
            this.labelScreenShare.Text = "SCREEN SHARE";
            this.labelScreenShare.Click += new System.EventHandler(this.btnScreenShare_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.tableLayoutPanel3);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelTop.ForeColor = System.Drawing.Color.White;
            this.PanelTop.Location = new System.Drawing.Point(4, 3);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Padding = new System.Windows.Forms.Padding(5);
            this.PanelTop.ShowText = true;
            this.PanelTop.Size = new System.Drawing.Size(1272, 69);
            this.PanelTop.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.CloseButton, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.SettingButton, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RoomNameLabel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1272, 69);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CloseButton.Location = new System.Drawing.Point(1211, 14);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedColor = System.Drawing.Color.Firebrick;
            this.CloseButton.Size = new System.Drawing.Size(56, 40);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingButton.BackgroundImage")));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.SettingButton.Location = new System.Drawing.Point(1145, 14);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.PressedColor = System.Drawing.Color.Firebrick;
            this.SettingButton.Size = new System.Drawing.Size(56, 40);
            this.SettingButton.TabIndex = 9;
            this.SettingButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetButton.BackgroundImage")));
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ResetButton.Location = new System.Drawing.Point(1079, 14);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.PressedColor = System.Drawing.Color.Firebrick;
            this.ResetButton.Size = new System.Drawing.Size(56, 40);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 63);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RoomNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNameLabel.ForeColor = System.Drawing.Color.White;
            this.RoomNameLabel.Location = new System.Drawing.Point(140, 0);
            this.RoomNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(167, 69);
            this.RoomNameLabel.TabIndex = 3;
            this.RoomNameLabel.Text = "RoomName";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StreamLayout
            // 
            this.StreamLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StreamLayout.ColumnCount = 2;
            this.StreamLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.StreamLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.StreamLayout.Controls.Add(this.panel1, 1, 0);
            this.StreamLayout.Controls.Add(this.PanelNothing, 0, 0);
            this.StreamLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreamLayout.Location = new System.Drawing.Point(4, 78);
            this.StreamLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StreamLayout.Name = "StreamLayout";
            this.StreamLayout.RowCount = 1;
            this.StreamLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StreamLayout.Size = new System.Drawing.Size(1272, 598);
            this.StreamLayout.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1064, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 592);
            this.panel1.TabIndex = 4;
            // 
            // PanelNothing
            // 
            this.PanelNothing.BackColor = System.Drawing.Color.Silver;
            this.PanelNothing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelNothing.BackgroundImage")));
            this.PanelNothing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelNothing.Controls.Add(this.pictureBoxRemoteVideo);
            this.PanelNothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNothing.Location = new System.Drawing.Point(4, 3);
            this.PanelNothing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelNothing.Name = "PanelNothing";
            this.PanelNothing.Size = new System.Drawing.Size(1052, 592);
            this.PanelNothing.TabIndex = 5;
            // 
            // pictureBoxRemoteVideo
            // 
            this.pictureBoxRemoteVideo.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxRemoteVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRemoteVideo.BackgroundImage")));
            this.pictureBoxRemoteVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRemoteVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRemoteVideo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRemoteVideo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBoxRemoteVideo.Name = "pictureBoxRemoteVideo";
            this.pictureBoxRemoteVideo.Size = new System.Drawing.Size(1052, 592);
            this.pictureBoxRemoteVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRemoteVideo.TabIndex = 3;
            this.pictureBoxRemoteVideo.TabStop = false;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = false;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1137, -5);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 94;
            this.nightControlBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nightControlBox1_MouseClick);
            // 
            // Broadcaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.formTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(110, 38);
            this.Name = "Broadcaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSI X DESKTOP BROADCASTER";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Broadcaster_FormClosed);
            this.Load += new System.EventHandler(this.Conference_Load);
            this.formTheme1.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.PanelBot.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StreamLayout.ResumeLayout(false);
            this.StreamLayout.PerformLayout();
            this.PanelNothing.ResumeLayout(false);
            this.PanelNothing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoteVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private ReaLTaiizor.Controls.LostPanel PanelBot;
        private ReaLTaiizor.Controls.LostPanel PanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.Button CloseButton;
        private ReaLTaiizor.Controls.Button SettingButton;
        private ReaLTaiizor.Controls.Button ResetButton;
        private ReaLTaiizor.Controls.SkyLabel RoomNameLabel;
        private System.Windows.Forms.TableLayoutPanel StreamLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelNothing;
        private System.Windows.Forms.PictureBox pictureBoxRemoteVideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBar1;
        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelMicrophone;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label labelScreenShare;
    }
}