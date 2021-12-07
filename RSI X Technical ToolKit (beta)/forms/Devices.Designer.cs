
namespace RSI_X_Desktop.forms
{
    partial class Devices
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
            this.materialShowTabControl1 = new ReaLTaiizor.Controls.MaterialShowTabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.BCloseGeneral = new ReaLTaiizor.Controls.Button();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.Sound = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Microphone = new ReaLTaiizor.Controls.DungeonLabel();
            this.trackBarSoundIn = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.trackBarSoundOut = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.Dynamic = new ReaLTaiizor.Controls.DungeonLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BCloseSound = new ReaLTaiizor.Controls.Button();
            this.BAcceptSound = new ReaLTaiizor.Controls.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxAudioInput = new ReaLTaiizor.Controls.AloneComboBox();
            this.MicTestBtn = new ReaLTaiizor.Controls.HopeButton();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.SpeakerTestBtn = new ReaLTaiizor.Controls.HopeButton();
            this.comboBoxAudioOutput = new ReaLTaiizor.Controls.AloneComboBox();
            this.Video = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BCloseVideo = new ReaLTaiizor.Controls.Button();
            this.BAcceptVideo = new ReaLTaiizor.Controls.Button();
            this.pictureBoxLocalVideoTest = new ReaLTaiizor.Controls.HopePictureBox();
            this.comboBoxVideo = new ReaLTaiizor.Controls.AloneComboBox();
            this.resComboBox = new ReaLTaiizor.Controls.AloneComboBox();
            this.button6 = new ReaLTaiizor.Controls.Button();
            this.button7 = new ReaLTaiizor.Controls.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.materialShowTabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.Sound.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.Video.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialShowTabControl1
            // 
            this.materialShowTabControl1.Controls.Add(this.General);
            this.materialShowTabControl1.Controls.Add(this.Sound);
            this.materialShowTabControl1.Controls.Add(this.Video);
            this.materialShowTabControl1.Depth = 0;
            this.materialShowTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialShowTabControl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialShowTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialShowTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialShowTabControl1.Multiline = true;
            this.materialShowTabControl1.Name = "materialShowTabControl1";
            this.materialShowTabControl1.SelectedIndex = 0;
            this.materialShowTabControl1.Size = new System.Drawing.Size(360, 541);
            this.materialShowTabControl1.TabIndex = 2;
            this.materialShowTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialShowTabControl1_SelectedIndexChanged);
            this.materialShowTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialShowTabControl1_Selecting);
            this.materialShowTabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialShowTabControl1_Deselecting);
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.White;
            this.General.CausesValidation = false;
            this.General.Controls.Add(this.tableLayoutPanel5);
            this.General.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.General.Location = new System.Drawing.Point(4, 33);
            this.General.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.General.Size = new System.Drawing.Size(352, 504);
            this.General.TabIndex = 4;
            this.General.Text = "General";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.bigLabel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dungeonLabel1, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.dungeonLabel3, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.dungeonLabel2, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 9;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(348, 498);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.BCloseGeneral, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(145, 441);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 54);
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
            this.BCloseGeneral.Location = new System.Drawing.Point(117, 9);
            this.BCloseGeneral.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseGeneral.Name = "BCloseGeneral";
            this.BCloseGeneral.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Size = new System.Drawing.Size(80, 28);
            this.BCloseGeneral.TabIndex = 6;
            this.BCloseGeneral.Text = "Close";
            this.BCloseGeneral.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BCloseGeneral.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(2, 0);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(109, 29);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Your system";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(2, 34);
            this.dungeonLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(87, 19);
            this.dungeonLabel1.TabIndex = 1;
            this.dungeonLabel1.Text = "dungeonLabel1";
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(2, 82);
            this.dungeonLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(89, 19);
            this.dungeonLabel3.TabIndex = 3;
            this.dungeonLabel3.Text = "dungeonLabel3";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(2, 58);
            this.dungeonLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(89, 19);
            this.dungeonLabel2.TabIndex = 2;
            this.dungeonLabel2.Text = "dungeonLabel2";
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.White;
            this.Sound.Controls.Add(this.tableLayoutPanel1);
            this.Sound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sound.Location = new System.Drawing.Point(4, 33);
            this.Sound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Sound.Name = "Sound";
            this.Sound.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Sound.Size = new System.Drawing.Size(352, 504);
            this.Sound.TabIndex = 7;
            this.Sound.Text = "Sound";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Microphone, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarSoundIn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBarSoundOut, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Dynamic, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 498);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Microphone
            // 
            this.Microphone.AutoSize = true;
            this.Microphone.BackColor = System.Drawing.Color.Transparent;
            this.Microphone.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Microphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.Microphone.Location = new System.Drawing.Point(2, 0);
            this.Microphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Microphone.Name = "Microphone";
            this.Microphone.Size = new System.Drawing.Size(66, 18);
            this.Microphone.TabIndex = 4;
            this.Microphone.Text = "Microphone";
            // 
            // trackBarSoundIn
            // 
            this.trackBarSoundIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSoundIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.trackBarSoundIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundIn.DrawValueString = false;
            this.trackBarSoundIn.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundIn.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.trackBarSoundIn.JumpToMouse = false;
            this.trackBarSoundIn.Location = new System.Drawing.Point(2, 64);
            this.trackBarSoundIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBarSoundIn.Maximum = 255;
            this.trackBarSoundIn.Minimum = 0;
            this.trackBarSoundIn.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundIn.Name = "trackBarSoundIn";
            this.trackBarSoundIn.Size = new System.Drawing.Size(344, 22);
            this.trackBarSoundIn.TabIndex = 2;
            this.trackBarSoundIn.Text = "dungeonTrackBar1";
            this.trackBarSoundIn.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBarSoundIn.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBarSoundIn.Value = 0;
            this.trackBarSoundIn.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.trackBarSoundIn.ValueToSet = 0F;
            this.trackBarSoundIn.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBarSoundIn_ValueChanged);
            // 
            // trackBarSoundOut
            // 
            this.trackBarSoundOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSoundOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarSoundOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.trackBarSoundOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundOut.DrawValueString = false;
            this.trackBarSoundOut.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundOut.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.trackBarSoundOut.JumpToMouse = true;
            this.trackBarSoundOut.Location = new System.Drawing.Point(2, 174);
            this.trackBarSoundOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBarSoundOut.Maximum = 100;
            this.trackBarSoundOut.Minimum = 0;
            this.trackBarSoundOut.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundOut.Name = "trackBarSoundOut";
            this.trackBarSoundOut.Size = new System.Drawing.Size(344, 22);
            this.trackBarSoundOut.TabIndex = 3;
            this.trackBarSoundOut.Text = "dungeonTrackBar1";
            this.trackBarSoundOut.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBarSoundOut.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBarSoundOut.Value = 50;
            this.trackBarSoundOut.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.trackBarSoundOut.ValueToSet = 50F;
            this.trackBarSoundOut.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBarSoundOut_ValueChanged);
            // 
            // Dynamic
            // 
            this.Dynamic.AutoSize = true;
            this.Dynamic.BackColor = System.Drawing.Color.Transparent;
            this.Dynamic.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dynamic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.Dynamic.Location = new System.Drawing.Point(2, 110);
            this.Dynamic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dynamic.Name = "Dynamic";
            this.Dynamic.Size = new System.Drawing.Size(49, 18);
            this.Dynamic.TabIndex = 5;
            this.Dynamic.Text = "Speaker";
            this.Dynamic.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BCloseSound, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BAcceptSound, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(145, 441);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 54);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // BCloseSound
            // 
            this.BCloseSound.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BCloseSound.BackColor = System.Drawing.Color.Transparent;
            this.BCloseSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCloseSound.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseSound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCloseSound.Image = null;
            this.BCloseSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCloseSound.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseSound.Location = new System.Drawing.Point(117, 9);
            this.BCloseSound.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseSound.Name = "BCloseSound";
            this.BCloseSound.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseSound.Size = new System.Drawing.Size(80, 28);
            this.BCloseSound.TabIndex = 6;
            this.BCloseSound.Text = "Close";
            this.BCloseSound.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BCloseSound.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BAcceptSound
            // 
            this.BAcceptSound.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BAcceptSound.BackColor = System.Drawing.Color.Transparent;
            this.BAcceptSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAcceptSound.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptSound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAcceptSound.Image = null;
            this.BAcceptSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAcceptSound.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptSound.Location = new System.Drawing.Point(17, 9);
            this.BAcceptSound.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BAcceptSound.Name = "BAcceptSound";
            this.BAcceptSound.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BAcceptSound.Size = new System.Drawing.Size(80, 28);
            this.BAcceptSound.TabIndex = 7;
            this.BAcceptSound.Text = "Accept";
            this.BAcceptSound.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BAcceptSound.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.Controls.Add(this.comboBoxAudioInput, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.MicTestBtn, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(342, 34);
            this.tableLayoutPanel9.TabIndex = 7;
            // 
            // comboBoxAudioInput
            // 
            this.comboBoxAudioInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAudioInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioInput.EnabledCalc = true;
            this.comboBoxAudioInput.FormattingEnabled = true;
            this.comboBoxAudioInput.ItemHeight = 20;
            this.comboBoxAudioInput.Location = new System.Drawing.Point(2, 4);
            this.comboBoxAudioInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioInput.Name = "comboBoxAudioInput";
            this.comboBoxAudioInput.Size = new System.Drawing.Size(269, 26);
            this.comboBoxAudioInput.TabIndex = 1;
            this.comboBoxAudioInput.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioInput_SelectedIndexChanged);
            // 
            // MicTestBtn
            // 
            this.MicTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MicTestBtn.BorderColor = System.Drawing.Color.Silver;
            this.MicTestBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.MicTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MicTestBtn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.MicTestBtn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MicTestBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MicTestBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MicTestBtn.HoverTextColor = System.Drawing.Color.Black;
            this.MicTestBtn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.MicTestBtn.Location = new System.Drawing.Point(276, 3);
            this.MicTestBtn.Name = "MicTestBtn";
            this.MicTestBtn.Padding = new System.Windows.Forms.Padding(5);
            this.MicTestBtn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MicTestBtn.Size = new System.Drawing.Size(63, 28);
            this.MicTestBtn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.MicTestBtn.TabIndex = 2;
            this.MicTestBtn.Text = "Test";
            this.MicTestBtn.TextColor = System.Drawing.Color.Gray;
            this.MicTestBtn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.MicTestBtn.Click += new System.EventHandler(this.MicTestClicked);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Controls.Add(this.SpeakerTestBtn, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.comboBoxAudioOutput, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(342, 34);
            this.tableLayoutPanel10.TabIndex = 8;
            // 
            // SpeakerTestBtn
            // 
            this.SpeakerTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SpeakerTestBtn.BorderColor = System.Drawing.Color.Silver;
            this.SpeakerTestBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Default;
            this.SpeakerTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeakerTestBtn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SpeakerTestBtn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SpeakerTestBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeakerTestBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeakerTestBtn.HoverTextColor = System.Drawing.Color.Black;
            this.SpeakerTestBtn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.SpeakerTestBtn.Location = new System.Drawing.Point(276, 3);
            this.SpeakerTestBtn.Name = "SpeakerTestBtn";
            this.SpeakerTestBtn.Padding = new System.Windows.Forms.Padding(5);
            this.SpeakerTestBtn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SpeakerTestBtn.Size = new System.Drawing.Size(63, 28);
            this.SpeakerTestBtn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.SpeakerTestBtn.TabIndex = 3;
            this.SpeakerTestBtn.Text = "Test";
            this.SpeakerTestBtn.TextColor = System.Drawing.Color.Gray;
            this.SpeakerTestBtn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.SpeakerTestBtn.Click += new System.EventHandler(this.SpeakerTestBtn_Click);
            // 
            // comboBoxAudioOutput
            // 
            this.comboBoxAudioOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAudioOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioOutput.EnabledCalc = true;
            this.comboBoxAudioOutput.FormattingEnabled = true;
            this.comboBoxAudioOutput.ItemHeight = 20;
            this.comboBoxAudioOutput.Location = new System.Drawing.Point(2, 4);
            this.comboBoxAudioOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioOutput.Name = "comboBoxAudioOutput";
            this.comboBoxAudioOutput.Size = new System.Drawing.Size(269, 26);
            this.comboBoxAudioOutput.TabIndex = 0;
            this.comboBoxAudioOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioOutput_SelectedIndexChanged);
            // 
            // Video
            // 
            this.Video.BackColor = System.Drawing.Color.White;
            this.Video.Controls.Add(this.tableLayoutPanel3);
            this.Video.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Video.Location = new System.Drawing.Point(4, 33);
            this.Video.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Video.Name = "Video";
            this.Video.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Video.Size = new System.Drawing.Size(352, 504);
            this.Video.TabIndex = 6;
            this.Video.Text = "Video";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxLocalVideoTest, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxVideo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.resComboBox, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(348, 498);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.BCloseVideo, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BAcceptVideo, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(145, 441);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 54);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // BCloseVideo
            // 
            this.BCloseVideo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BCloseVideo.BackColor = System.Drawing.Color.Transparent;
            this.BCloseVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCloseVideo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCloseVideo.Image = null;
            this.BCloseVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCloseVideo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseVideo.Location = new System.Drawing.Point(117, 9);
            this.BCloseVideo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseVideo.Name = "BCloseVideo";
            this.BCloseVideo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseVideo.Size = new System.Drawing.Size(80, 28);
            this.BCloseVideo.TabIndex = 2;
            this.BCloseVideo.Text = "Close";
            this.BCloseVideo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BCloseVideo.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BAcceptVideo
            // 
            this.BAcceptVideo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BAcceptVideo.BackColor = System.Drawing.Color.Transparent;
            this.BAcceptVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAcceptVideo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAcceptVideo.Image = null;
            this.BAcceptVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAcceptVideo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptVideo.Location = new System.Drawing.Point(17, 9);
            this.BAcceptVideo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BAcceptVideo.Name = "BAcceptVideo";
            this.BAcceptVideo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BAcceptVideo.Size = new System.Drawing.Size(80, 28);
            this.BAcceptVideo.TabIndex = 3;
            this.BAcceptVideo.Text = "Accept";
            this.BAcceptVideo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BAcceptVideo.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // pictureBoxLocalVideoTest
            // 
            this.pictureBoxLocalVideoTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.pictureBoxLocalVideoTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLocalVideoTest.Location = new System.Drawing.Point(2, 3);
            this.pictureBoxLocalVideoTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLocalVideoTest.Name = "pictureBoxLocalVideoTest";
            this.pictureBoxLocalVideoTest.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pictureBoxLocalVideoTest.Size = new System.Drawing.Size(344, 198);
            this.pictureBoxLocalVideoTest.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pictureBoxLocalVideoTest.TabIndex = 1;
            this.pictureBoxLocalVideoTest.TabStop = false;
            this.pictureBoxLocalVideoTest.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // comboBoxVideo
            // 
            this.comboBoxVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxVideo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideo.EnabledCalc = true;
            this.comboBoxVideo.FormattingEnabled = true;
            this.comboBoxVideo.ItemHeight = 20;
            this.comboBoxVideo.Location = new System.Drawing.Point(2, 207);
            this.comboBoxVideo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxVideo.Name = "comboBoxVideo";
            this.comboBoxVideo.Size = new System.Drawing.Size(344, 26);
            this.comboBoxVideo.TabIndex = 0;
            this.comboBoxVideo.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideo_SelectedIndexChanged);
            // 
            // resComboBox
            // 
            this.resComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resComboBox.EnabledCalc = true;
            this.resComboBox.FormattingEnabled = true;
            this.resComboBox.ItemHeight = 20;
            this.resComboBox.Location = new System.Drawing.Point(2, 257);
            this.resComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resComboBox.Name = "resComboBox";
            this.resComboBox.Size = new System.Drawing.Size(344, 26);
            this.resComboBox.TabIndex = 9;
            this.resComboBox.SelectedIndexChanged += new System.EventHandler(this.resComboBox_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Image = null;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button6.Location = new System.Drawing.Point(17, 32);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button6.Name = "button6";
            this.button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button6.Size = new System.Drawing.Size(80, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "Accept";
            this.button6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button6.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button7.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Image = null;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button7.Location = new System.Drawing.Point(117, 32);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button7.Name = "button7";
            this.button7.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button7.Size = new System.Drawing.Size(80, 28);
            this.button7.TabIndex = 2;
            this.button7.Text = "Close";
            this.button7.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button7.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(117, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button1.Name = "button1";
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 541);
            this.Controls.Add(this.materialShowTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(90, 47);
            this.Name = "Devices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDevices_FormClosed);
            this.Load += new System.EventHandler(this.NewDevices_Load);
            this.materialShowTabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.Sound.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.Video.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialShowTabControl materialShowTabControl1;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage Sound;
        private ReaLTaiizor.Controls.Button BAcceptSound;
        private ReaLTaiizor.Controls.Button BCloseSound;
        private ReaLTaiizor.Controls.DungeonLabel Dynamic;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundOut;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundIn;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxAudioInput;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxAudioOutput;
        private System.Windows.Forms.TabPage Video;
        private ReaLTaiizor.Controls.Button BAcceptVideo;
        private ReaLTaiizor.Controls.Button BCloseVideo;
        private ReaLTaiizor.Controls.HopePictureBox pictureBoxLocalVideoTest;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxVideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonLabel Microphone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.Button button6;
        private ReaLTaiizor.Controls.Button button7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private ReaLTaiizor.Controls.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.Button BCloseGeneral;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private ReaLTaiizor.Controls.HopeButton MicTestBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private ReaLTaiizor.Controls.HopeButton SpeakerTestBtn;
        private ReaLTaiizor.Controls.AloneComboBox resComboBox;
    }
}