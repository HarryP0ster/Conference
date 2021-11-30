namespace RSI_X_Desktop.forms
{
    partial class LangSelectDlg
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
            this.formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            this.BClose = new ReaLTaiizor.Controls.DungeonControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmblang = new ReaLTaiizor.Controls.PoisonComboBox();
            this.labelLng = new System.Windows.Forms.Label();
            this.textBoxNickName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BAccept = new ReaLTaiizor.Controls.Button();
            this.CheckBoxCam = new ReaLTaiizor.Controls.FoxCheckBoxEdit();
            this.CheckBoxMic = new ReaLTaiizor.Controls.FoxCheckBoxEdit();
            this.formTheme1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTheme1
            // 
            this.formTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formTheme1.Controls.Add(this.BClose);
            this.formTheme1.Controls.Add(this.tableLayoutPanel1);
            this.formTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTheme1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.formTheme1.Location = new System.Drawing.Point(0, 0);
            this.formTheme1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formTheme1.Name = "formTheme1";
            this.formTheme1.Padding = new System.Windows.Forms.Padding(3, 25, 3, 10);
            this.formTheme1.Sizable = false;
            this.formTheme1.Size = new System.Drawing.Size(500, 280);
            this.formTheme1.SmartBounds = false;
            this.formTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.formTheme1.TabIndex = 0;
            this.formTheme1.Text = "Conference settings";
            // 
            // BClose
            // 
            this.BClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BClose.BackColor = System.Drawing.Color.Transparent;
            this.BClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClose.DefaultLocation = false;
            this.BClose.EnableMaximize = false;
            this.BClose.EnableMinimize = false;
            this.BClose.Font = new System.Drawing.Font("Marlett", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BClose.Location = new System.Drawing.Point(471, 0);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(23, 22);
            this.BClose.TabIndex = 101;
            this.BClose.Text = "dungeonControlBox1";
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 245);
            this.tableLayoutPanel1.TabIndex = 100;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNickName, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(488, 153);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Controls.Add(this.cmblang, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelLng, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(100, 64);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(286, 86);
            this.tableLayoutPanel5.TabIndex = 99;
            // 
            // cmblang
            // 
            this.cmblang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmblang.FormattingEnabled = true;
            this.cmblang.ItemHeight = 23;
            this.cmblang.Location = new System.Drawing.Point(45, 46);
            this.cmblang.Name = "cmblang";
            this.cmblang.Size = new System.Drawing.Size(194, 29);
            this.cmblang.TabIndex = 99;
            this.cmblang.UseSelectable = true;
            // 
            // labelLng
            // 
            this.labelLng.AutoSize = true;
            this.labelLng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLng.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLng.ForeColor = System.Drawing.Color.White;
            this.labelLng.Location = new System.Drawing.Point(45, 0);
            this.labelLng.Name = "labelLng";
            this.labelLng.Size = new System.Drawing.Size(194, 43);
            this.labelLng.TabIndex = 1;
            this.labelLng.Text = "Source language";
            this.labelLng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxNickName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxNickName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNickName.EdgeColor = System.Drawing.Color.White;
            this.textBoxNickName.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNickName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxNickName.Location = new System.Drawing.Point(100, 10);
            this.textBoxNickName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxNickName.MaxLength = 16;
            this.textBoxNickName.Multiline = false;
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.ReadOnly = false;
            this.textBoxNickName.Size = new System.Drawing.Size(286, 36);
            this.textBoxNickName.TabIndex = 100;
            this.textBoxNickName.Text = "Your name";
            this.textBoxNickName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNickName.UseSystemPasswordChar = false;
            this.textBoxNickName.Enter += new System.EventHandler(this.textBoxNickName_Enter);
            this.textBoxNickName.Leave += new System.EventHandler(this.textBoxNickName_Leave);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.CheckBoxCam, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.CheckBoxMic, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 162);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(488, 80);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BAccept, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(327, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 36);
            this.tableLayoutPanel2.TabIndex = 96;
            // 
            // BAccept
            // 
            this.BAccept.BackColor = System.Drawing.Color.Transparent;
            this.BAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BAccept.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAccept.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAccept.Image = null;
            this.BAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAccept.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAccept.Location = new System.Drawing.Point(82, 3);
            this.BAccept.Name = "BAccept";
            this.BAccept.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BAccept.Size = new System.Drawing.Size(73, 30);
            this.BAccept.TabIndex = 7;
            this.BAccept.Text = "Join";
            this.BAccept.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // CheckBoxCam
            // 
            this.CheckBoxCam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckBoxCam.Checked = true;
            this.CheckBoxCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxCam.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CheckBoxCam.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.CheckBoxCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxCam.EnabledCalc = true;
            this.CheckBoxCam.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxCam.ForeColor = System.Drawing.Color.White;
            this.CheckBoxCam.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.CheckBoxCam.Location = new System.Drawing.Point(167, 4);
            this.CheckBoxCam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CheckBoxCam.Name = "CheckBoxCam";
            this.CheckBoxCam.Size = new System.Drawing.Size(152, 32);
            this.CheckBoxCam.TabIndex = 98;
            this.CheckBoxCam.Text = "Enable camera";
            // 
            // CheckBoxMic
            // 
            this.CheckBoxMic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckBoxMic.Checked = true;
            this.CheckBoxMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxMic.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CheckBoxMic.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.CheckBoxMic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxMic.EnabledCalc = true;
            this.CheckBoxMic.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxMic.ForeColor = System.Drawing.Color.White;
            this.CheckBoxMic.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.CheckBoxMic.Location = new System.Drawing.Point(167, 44);
            this.CheckBoxMic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CheckBoxMic.Name = "CheckBoxMic";
            this.CheckBoxMic.Size = new System.Drawing.Size(152, 32);
            this.CheckBoxMic.TabIndex = 97;
            this.CheckBoxMic.Text = "Enable microphone";
            // 
            // LangSelectDlg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.formTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(110, 38);
            this.Name = "LangSelectDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conference settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LangSelectDlg_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LangSelectDlg_FormClosed);
            this.formTheme1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private System.Windows.Forms.Label labelLng;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.Button BAccept;
        private ReaLTaiizor.Controls.PoisonComboBox cmblang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ReaLTaiizor.Controls.FoxCheckBoxEdit CheckBoxCam;
        private ReaLTaiizor.Controls.FoxCheckBoxEdit CheckBoxMic;
        private ReaLTaiizor.Controls.DungeonTextBox textBoxNickName;
        private ReaLTaiizor.Controls.DungeonControlBox BClose;
    }
}