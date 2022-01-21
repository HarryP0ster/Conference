
namespace RSI_X_Desktop.forms.HelpingClass
{
    partial class LangWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LangWnd));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ContinueBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.DevicesBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.MuteMic = new DevExpress.XtraEditors.SvgImageBox();
            this.MuteCam = new DevExpress.XtraEditors.SvgImageBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.langBox = new ReaLTaiizor.Controls.SkyComboBox();
            this.NicknameBox = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContinueBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteCam)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NicknameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.NameLabel);
            this.tablePanel1.Controls.Add(this.pictureBox1);
            this.tablePanel1.Controls.Add(this.tableLayoutPanel2);
            this.tablePanel1.Controls.Add(this.MuteMic);
            this.tablePanel1.Controls.Add(this.MuteCam);
            this.tablePanel1.Controls.Add(this.tableLayoutPanel1);
            this.tablePanel1.Controls.Add(this.NicknameBox);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel1.Size = new System.Drawing.Size(450, 450);
            this.tablePanel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.tablePanel1.SetColumn(this.NameLabel, 0);
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(3, 68);
            this.NameLabel.Name = "NameLabel";
            this.tablePanel1.SetRow(this.NameLabel, 1);
            this.NameLabel.Size = new System.Drawing.Size(444, 45);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "RSI X CONFERENCE";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.tablePanel1.SetColumn(this.pictureBox1, 0);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RSI_X_Desktop.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel1.SetRow(this.pictureBox1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(440, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tablePanel1.SetColumn(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ContinueBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DevicesBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 341);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tablePanel1.SetRow(this.tableLayoutPanel2, 6);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 106);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ContinueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinueBtn.Location = new System.Drawing.Point(237, 15);
            this.ContinueBtn.Margin = new System.Windows.Forms.Padding(15);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(192, 76);
            this.ContinueBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ContinueBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ContinueBtn.SvgImage")));
            this.ContinueBtn.TabIndex = 0;
            this.ContinueBtn.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // DevicesBtn
            // 
            this.DevicesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevicesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevicesBtn.Location = new System.Drawing.Point(15, 15);
            this.DevicesBtn.Margin = new System.Windows.Forms.Padding(15);
            this.DevicesBtn.Name = "DevicesBtn";
            this.DevicesBtn.Size = new System.Drawing.Size(192, 76);
            this.DevicesBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.DevicesBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DevicesBtn.SvgImage")));
            this.DevicesBtn.TabIndex = 1;
            this.DevicesBtn.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.DevicesBtn.Click += new System.EventHandler(this.DevicesBtn_Click);
            // 
            // MuteMic
            // 
            this.tablePanel1.SetColumn(this.MuteMic, 0);
            this.MuteMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuteMic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MuteMic.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.MuteMic.ItemAppearance.Normal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MuteMic.Location = new System.Drawing.Point(60, 293);
            this.MuteMic.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.MuteMic.Name = "MuteMic";
            this.tablePanel1.SetRow(this.MuteMic, 5);
            this.MuteMic.Size = new System.Drawing.Size(390, 45);
            this.MuteMic.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.MuteMic.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MuteMic.SvgImage")));
            this.MuteMic.TabIndex = 3;
            this.MuteMic.Text = "svgImageBox1";
            this.MuteMic.Click += new System.EventHandler(this.MuteMic_Click);
            // 
            // MuteCam
            // 
            this.tablePanel1.SetColumn(this.MuteCam, 0);
            this.MuteCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuteCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MuteCam.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.MuteCam.ItemAppearance.Normal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MuteCam.Location = new System.Drawing.Point(60, 248);
            this.MuteCam.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.MuteCam.Name = "MuteCam";
            this.tablePanel1.SetRow(this.MuteCam, 4);
            this.MuteCam.Size = new System.Drawing.Size(390, 45);
            this.MuteCam.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.MuteCam.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MuteCam.SvgImage")));
            this.MuteCam.TabIndex = 2;
            this.MuteCam.Click += new System.EventHandler(this.MuteCam_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tablePanel1.SetColumn(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.langBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 206);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tablePanel1.SetRow(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(40, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // langBox
            // 
            this.langBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.langBox.BGColorA = System.Drawing.Color.Transparent;
            this.langBox.BGColorB = System.Drawing.Color.Transparent;
            this.langBox.BorderColorA = System.Drawing.Color.Transparent;
            this.langBox.BorderColorB = System.Drawing.Color.Transparent;
            this.langBox.BorderColorC = System.Drawing.Color.Transparent;
            this.langBox.BorderColorD = System.Drawing.Color.Transparent;
            this.langBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.langBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.langBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langBox.DropDownWidth = 74;
            this.langBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.langBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.langBox.ItemHeight = 22;
            this.langBox.ItemHighlightColor = System.Drawing.Color.Transparent;
            this.langBox.LineColorA = System.Drawing.Color.Transparent;
            this.langBox.LineColorB = System.Drawing.Color.Transparent;
            this.langBox.LineColorC = System.Drawing.Color.Transparent;
            this.langBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.ListBorderColor = System.Drawing.Color.White;
            this.langBox.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.langBox.ListForeColor = System.Drawing.Color.Black;
            this.langBox.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.Location = new System.Drawing.Point(266, 0);
            this.langBox.Margin = new System.Windows.Forms.Padding(0);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(84, 28);
            this.langBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.None;
            this.langBox.StartIndex = 0;
            this.langBox.TabIndex = 13;
            this.langBox.TriangleColorA = System.Drawing.Color.White;
            this.langBox.TriangleColorB = System.Drawing.Color.White;
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // NicknameBox
            // 
            this.NicknameBox.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.TextBoxShadow;
            this.NicknameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel1.SetColumn(this.NicknameBox, 0);
            this.NicknameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NicknameBox.ItemAppearance.Normal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.NicknameBox.Location = new System.Drawing.Point(15, 118);
            this.NicknameBox.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.NicknameBox.Name = "NicknameBox";
            this.tablePanel1.SetRow(this.NicknameBox, 2);
            this.NicknameBox.Size = new System.Drawing.Size(420, 80);
            this.NicknameBox.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.NicknameBox.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NicknameBox.SvgImage")));
            this.NicknameBox.TabIndex = 0;
            this.NicknameBox.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            // 
            // LangWnd
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("LangWnd.IconOptions.Icon")));
            this.Name = "LangWnd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LangWnd";
            this.Load += new System.EventHandler(this.LangWnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContinueBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteCam)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NicknameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SvgImageBox NicknameBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        internal ReaLTaiizor.Controls.SkyComboBox langBox;
        private DevExpress.XtraEditors.SvgImageBox MuteCam;
        private DevExpress.XtraEditors.SvgImageBox MuteMic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SvgImageBox ContinueBtn;
        private DevExpress.XtraEditors.SvgImageBox DevicesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
    }
}