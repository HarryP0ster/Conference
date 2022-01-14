
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
            this.StreamLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.streamsTable = new System.Windows.Forms.TableLayoutPanel();
            this.Nothing = new System.Windows.Forms.Panel();
            this.pictureBoxLocalVideo = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.formTheme1.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.StreamLayout.SuspendLayout();
            this.streamsTable.SuspendLayout();
            this.Nothing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideo)).BeginInit();
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
            this.formTheme1.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.formTheme1.Sizable = false;
            this.formTheme1.Size = new System.Drawing.Size(1280, 800);
            this.formTheme1.SmartBounds = false;
            this.formTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.formTheme1.TabIndex = 10;
            this.formTheme1.Text = "RSI X DESKTOP CONFERENCE";
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.StreamLayout, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 22);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(1280, 778);
            this.MainLayout.TabIndex = 93;
            // 
            // StreamLayout
            // 
            this.StreamLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StreamLayout.ColumnCount = 2;
            this.StreamLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.StreamLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.StreamLayout.Controls.Add(this.panel1, 1, 0);
            this.StreamLayout.Controls.Add(this.streamsTable, 0, 0);
            this.StreamLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreamLayout.Location = new System.Drawing.Point(90, 0);
            this.StreamLayout.Margin = new System.Windows.Forms.Padding(0);
            this.StreamLayout.Name = "StreamLayout";
            this.StreamLayout.RowCount = 1;
            this.StreamLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StreamLayout.Size = new System.Drawing.Size(1190, 778);
            this.StreamLayout.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(995, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 772);
            this.panel1.TabIndex = 4;
            // 
            // streamsTable
            // 
            this.streamsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.streamsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.streamsTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.streamsTable.ColumnCount = 1;
            this.streamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.streamsTable.Controls.Add(this.Nothing, 0, 0);
            this.streamsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamsTable.Location = new System.Drawing.Point(0, 0);
            this.streamsTable.Margin = new System.Windows.Forms.Padding(0);
            this.streamsTable.Name = "streamsTable";
            this.streamsTable.RowCount = 1;
            this.streamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.streamsTable.Size = new System.Drawing.Size(991, 778);
            this.streamsTable.TabIndex = 5;
            // 
            // Nothing
            // 
            this.Nothing.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.logotype;
            this.Nothing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nothing.Controls.Add(this.pictureBoxLocalVideo);
            this.Nothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nothing.Location = new System.Drawing.Point(0, 0);
            this.Nothing.Margin = new System.Windows.Forms.Padding(0);
            this.Nothing.Name = "Nothing";
            this.Nothing.Size = new System.Drawing.Size(991, 778);
            this.Nothing.TabIndex = 0;
            // 
            // pictureBoxLocalVideo
            // 
            this.pictureBoxLocalVideo.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxLocalVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLocalVideo.BackgroundImage")));
            this.pictureBoxLocalVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLocalVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLocalVideo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLocalVideo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLocalVideo.Name = "pictureBoxLocalVideo";
            this.pictureBoxLocalVideo.Size = new System.Drawing.Size(991, 778);
            this.pictureBoxLocalVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLocalVideo.TabIndex = 0;
            this.pictureBoxLocalVideo.TabStop = false;
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
            this.nightControlBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nightControlBox1_MouseMove);
            // 
            // Broadcaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.formTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Broadcaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSI X DESKTOP CONFERENCE";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Broadcaster_FormClosed);
            this.Load += new System.EventHandler(this.Conference_Load);
            this.formTheme1.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.StreamLayout.ResumeLayout(false);
            this.StreamLayout.PerformLayout();
            this.streamsTable.ResumeLayout(false);
            this.Nothing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        internal System.Windows.Forms.TableLayoutPanel StreamLayout;
        internal System.Windows.Forms.TableLayoutPanel streamsTable;
        internal System.Windows.Forms.PictureBox pictureBoxLocalVideo;
        private System.Windows.Forms.Panel Nothing;
    }
}