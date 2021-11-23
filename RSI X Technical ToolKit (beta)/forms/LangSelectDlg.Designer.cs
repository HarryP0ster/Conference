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
            this.cmblang = new System.Windows.Forms.ComboBox();
            this.labelLng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.formTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTheme1
            // 
            this.formTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.formTheme1.Controls.Add(this.textBox1);
            this.formTheme1.Controls.Add(this.label1);
            this.formTheme1.Controls.Add(this.labelLng);
            this.formTheme1.Controls.Add(this.cmblang);
            this.formTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTheme1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.formTheme1.Location = new System.Drawing.Point(0, 0);
            this.formTheme1.Name = "formTheme1";
            this.formTheme1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.formTheme1.Sizable = true;
            this.formTheme1.Size = new System.Drawing.Size(800, 450);
            this.formTheme1.SmartBounds = false;
            this.formTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.formTheme1.TabIndex = 0;
            this.formTheme1.Text = "formTheme1";
            // 
            // cmblang
            // 
            this.cmblang.FormattingEnabled = true;
            this.cmblang.Location = new System.Drawing.Point(63, 74);
            this.cmblang.Name = "cmblang";
            this.cmblang.Size = new System.Drawing.Size(151, 25);
            this.cmblang.TabIndex = 0;
            // 
            // labelLng
            // 
            this.labelLng.AutoSize = true;
            this.labelLng.Location = new System.Drawing.Point(9, 74);
            this.labelLng.Name = "labelLng";
            this.labelLng.Size = new System.Drawing.Size(42, 19);
            this.labelLng.TabIndex = 1;
            this.labelLng.Text = "Lang:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 25);
            this.textBox1.TabIndex = 3;
            // 
            // LangSelectDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "LangSelectDlg";
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formTheme1.ResumeLayout(false);
            this.formTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private System.Windows.Forms.Label labelLng;
        private System.Windows.Forms.ComboBox cmblang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}