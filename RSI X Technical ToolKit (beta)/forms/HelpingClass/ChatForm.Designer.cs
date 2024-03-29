﻿
namespace RSI_X_Desktop.forms.HelpingClass
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.TablePanels = new DevExpress.Utils.Layout.TablePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PBooth = new ReaLTaiizor.Controls.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BoothScroll = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.PGeneral = new ReaLTaiizor.Controls.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeneralScroll = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.ScrollPanel = new System.Windows.Forms.Panel();
            this.SupportScroll = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.PSupport = new ReaLTaiizor.Controls.Panel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.Booth = new DevExpress.XtraEditors.SvgImageBox();
            this.Support = new DevExpress.XtraEditors.SvgImageBox();
            this.General = new DevExpress.XtraEditors.SvgImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChatTextBox = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.ChatClose = new DevExpress.XtraEditors.SvgImageBox();
            this.SendMsgBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePanels)).BeginInit();
            this.TablePanels.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.ScrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Booth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Support)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.General)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChatClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.TablePanels);
            this.tablePanel1.Controls.Add(this.tablePanel4);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 65F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 195F)});
            this.tablePanel1.Size = new System.Drawing.Size(450, 800);
            this.tablePanel1.TabIndex = 0;
            // 
            // TablePanels
            // 
            this.tablePanel1.SetColumn(this.TablePanels, 0);
            this.TablePanels.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.TablePanels.Controls.Add(this.tableLayoutPanel1);
            this.TablePanels.Controls.Add(this.tableLayoutPanel8);
            this.TablePanels.Controls.Add(this.tableLayoutPanel7);
            this.TablePanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanels.Location = new System.Drawing.Point(10, 81);
            this.TablePanels.Margin = new System.Windows.Forms.Padding(0);
            this.TablePanels.Name = "TablePanels";
            this.tablePanel1.SetRow(this.TablePanels, 1);
            this.TablePanels.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.TablePanels.Size = new System.Drawing.Size(430, 524);
            this.TablePanels.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.TablePanels.SetColumn(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.PBooth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.TablePanels.SetRow(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(143, 524);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // PBooth
            // 
            this.PBooth.BackColor = System.Drawing.Color.White;
            this.PBooth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBooth.EdgeColor = System.Drawing.SystemColors.Control;
            this.PBooth.Location = new System.Drawing.Point(25, 0);
            this.PBooth.Margin = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.PBooth.Name = "PBooth";
            this.PBooth.Padding = new System.Windows.Forms.Padding(5);
            this.PBooth.Size = new System.Drawing.Size(100, 524);
            this.PBooth.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.PBooth.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.BoothScroll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(135, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 524);
            this.panel3.TabIndex = 5;
            // 
            // BoothScroll
            // 
            this.BoothScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoothScroll.LargeChange = 1;
            this.BoothScroll.Location = new System.Drawing.Point(0, 0);
            this.BoothScroll.Maximum = 1;
            this.BoothScroll.Minimum = 0;
            this.BoothScroll.MouseWheelBarPartitions = 1;
            this.BoothScroll.Name = "BoothScroll";
            this.BoothScroll.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.BoothScroll.ScrollbarSize = 8;
            this.BoothScroll.Size = new System.Drawing.Size(8, 524);
            this.BoothScroll.TabIndex = 5;
            this.BoothScroll.Text = "poisonScrollBar1";
            this.BoothScroll.UseSelectable = true;
            this.BoothScroll.ValueChanged += new ReaLTaiizor.Controls.PoisonScrollBar.ScrollValueChangedDelegate(this.BoothScroll_ValueChanged);
            // 
            // tableLayoutPanel8
            // 
            this.TablePanels.SetColumn(this.tableLayoutPanel8, 1);
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel8.Controls.Add(this.PGeneral, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(143, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.TablePanels.SetRow(this.tableLayoutPanel8, 0);
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(143, 524);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // PGeneral
            // 
            this.PGeneral.BackColor = System.Drawing.Color.White;
            this.PGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.PGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGeneral.EdgeColor = System.Drawing.SystemColors.Control;
            this.PGeneral.Location = new System.Drawing.Point(25, 0);
            this.PGeneral.Margin = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.PGeneral.Name = "PGeneral";
            this.PGeneral.Padding = new System.Windows.Forms.Padding(5);
            this.PGeneral.Size = new System.Drawing.Size(100, 524);
            this.PGeneral.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.PGeneral.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.GeneralScroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(135, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 524);
            this.panel1.TabIndex = 4;
            // 
            // GeneralScroll
            // 
            this.GeneralScroll.BackColor = System.Drawing.Color.White;
            this.GeneralScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralScroll.LargeChange = 1;
            this.GeneralScroll.Location = new System.Drawing.Point(0, 0);
            this.GeneralScroll.Maximum = 1;
            this.GeneralScroll.Minimum = 0;
            this.GeneralScroll.MouseWheelBarPartitions = 1;
            this.GeneralScroll.Name = "GeneralScroll";
            this.GeneralScroll.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.GeneralScroll.ScrollbarSize = 8;
            this.GeneralScroll.Size = new System.Drawing.Size(8, 524);
            this.GeneralScroll.TabIndex = 0;
            this.GeneralScroll.UseSelectable = true;
            this.GeneralScroll.ValueChanged += new ReaLTaiizor.Controls.PoisonScrollBar.ScrollValueChangedDelegate(this.GeneralScroll_ValueChanged);
            // 
            // tableLayoutPanel7
            // 
            this.TablePanels.SetColumn(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.Controls.Add(this.ScrollPanel, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.PSupport, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(287, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.TablePanels.SetRow(this.tableLayoutPanel7, 0);
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(143, 524);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // ScrollPanel
            // 
            this.ScrollPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ScrollPanel.Controls.Add(this.SupportScroll);
            this.ScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollPanel.Location = new System.Drawing.Point(135, 0);
            this.ScrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ScrollPanel.Name = "ScrollPanel";
            this.ScrollPanel.Size = new System.Drawing.Size(8, 524);
            this.ScrollPanel.TabIndex = 0;
            // 
            // SupportScroll
            // 
            this.SupportScroll.BackColor = System.Drawing.Color.White;
            this.SupportScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupportScroll.LargeChange = 1;
            this.SupportScroll.Location = new System.Drawing.Point(0, 0);
            this.SupportScroll.Maximum = 1;
            this.SupportScroll.Minimum = 0;
            this.SupportScroll.MouseWheelBarPartitions = 1;
            this.SupportScroll.Name = "SupportScroll";
            this.SupportScroll.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.SupportScroll.ScrollbarSize = 8;
            this.SupportScroll.Size = new System.Drawing.Size(8, 524);
            this.SupportScroll.TabIndex = 0;
            this.SupportScroll.UseSelectable = true;
            this.SupportScroll.ValueChanged += new ReaLTaiizor.Controls.PoisonScrollBar.ScrollValueChangedDelegate(this.SupportScroll_ValueChanged);
            // 
            // PSupport
            // 
            this.PSupport.BackColor = System.Drawing.Color.White;
            this.PSupport.Cursor = System.Windows.Forms.Cursors.Default;
            this.PSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSupport.EdgeColor = System.Drawing.SystemColors.Control;
            this.PSupport.Location = new System.Drawing.Point(25, 0);
            this.PSupport.Margin = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.PSupport.Name = "PSupport";
            this.PSupport.Padding = new System.Windows.Forms.Padding(5);
            this.PSupport.Size = new System.Drawing.Size(100, 524);
            this.PSupport.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.PSupport.TabIndex = 3;
            // 
            // tablePanel4
            // 
            this.tablePanel1.SetColumn(this.tablePanel4, 0);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F)});
            this.tablePanel4.Controls.Add(this.Booth);
            this.tablePanel4.Controls.Add(this.Support);
            this.tablePanel4.Controls.Add(this.General);
            this.tablePanel4.Controls.Add(this.label1);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(13, 3);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel1.SetRow(this.tablePanel4, 0);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(424, 75);
            this.tablePanel4.TabIndex = 4;
            // 
            // Booth
            // 
            this.tablePanel4.SetColumn(this.Booth, 1);
            this.Booth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Booth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Booth.Location = new System.Drawing.Point(202, 3);
            this.Booth.Name = "Booth";
            this.tablePanel4.SetRow(this.Booth, 0);
            this.Booth.Size = new System.Drawing.Size(69, 69);
            this.Booth.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Booth.SvgImage")));
            this.Booth.TabIndex = 3;
            this.Booth.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.Booth.Click += new System.EventHandler(this.Booth_Click);
            // 
            // Support
            // 
            this.tablePanel4.SetColumn(this.Support, 3);
            this.Support.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Support.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Support.Location = new System.Drawing.Point(352, 3);
            this.Support.Name = "Support";
            this.tablePanel4.SetRow(this.Support, 0);
            this.Support.Size = new System.Drawing.Size(69, 69);
            this.Support.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Support.SvgImage")));
            this.Support.TabIndex = 2;
            this.Support.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.Support.Click += new System.EventHandler(this.Support_Click);
            // 
            // General
            // 
            this.tablePanel4.SetColumn(this.General, 2);
            this.General.Cursor = System.Windows.Forms.Cursors.Hand;
            this.General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.General.Location = new System.Drawing.Point(277, 3);
            this.General.Name = "General";
            this.tablePanel4.SetRow(this.General, 0);
            this.General.Size = new System.Drawing.Size(69, 69);
            this.General.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("General.SvgImage")));
            this.General.TabIndex = 1;
            this.General.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.General.Click += new System.EventHandler(this.General_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel4.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePanel4.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(193, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSI X Chat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel2.Controls.Add(this.panel2);
            this.tablePanel2.Controls.Add(this.ChatTextBox);
            this.tablePanel2.Controls.Add(this.tablePanel3);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(10, 610);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 2);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 3F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 61.43F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.57F)});
            this.tablePanel2.Size = new System.Drawing.Size(430, 190);
            this.tablePanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.tablePanel2.SetColumn(this.panel2, 0);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.tablePanel2.SetRow(this.panel2, 0);
            this.panel2.Size = new System.Drawing.Size(430, 3);
            this.panel2.TabIndex = 3;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BorderColor = System.Drawing.Color.White;
            this.tablePanel2.SetColumn(this.ChatTextBox, 0);
            this.ChatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChatTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatTextBox.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChatTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ChatTextBox.Hint = "";
            this.ChatTextBox.HoverBorderColor = System.Drawing.Color.White;
            this.ChatTextBox.Location = new System.Drawing.Point(10, 18);
            this.ChatTextBox.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.ChatTextBox.MaxLength = 127;
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.PasswordChar = '\0';
            this.tablePanel2.SetRow(this.ChatTextBox, 1);
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChatTextBox.SelectedText = "";
            this.ChatTextBox.SelectionLength = 0;
            this.ChatTextBox.SelectionStart = 0;
            this.ChatTextBox.Size = new System.Drawing.Size(417, 97);
            this.ChatTextBox.TabIndex = 1;
            this.ChatTextBox.TabStop = false;
            this.ChatTextBox.Text = "Type in your message";
            this.ChatTextBox.UseSystemPasswordChar = false;
            this.ChatTextBox.Enter += new System.EventHandler(this.bigTextBox2_Enter);
            this.ChatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.ChatTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bigTextBox2_KeyUp);
            this.ChatTextBox.Leave += new System.EventHandler(this.bigTextBox2_Leave);
            // 
            // tablePanel3
            // 
            this.tablePanel2.SetColumn(this.tablePanel3, 0);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.tablePanel3.Controls.Add(this.ChatClose);
            this.tablePanel3.Controls.Add(this.SendMsgBtn);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(3, 121);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel2.SetRow(this.tablePanel3, 2);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(424, 66);
            this.tablePanel3.TabIndex = 2;
            // 
            // ChatClose
            // 
            this.tablePanel3.SetColumn(this.ChatClose, 2);
            this.ChatClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.ChatClose.ItemAppearance.Normal.FillColor = System.Drawing.Color.Gray;
            this.ChatClose.Location = new System.Drawing.Point(370, 10);
            this.ChatClose.Margin = new System.Windows.Forms.Padding(10);
            this.ChatClose.Name = "ChatClose";
            this.tablePanel3.SetRow(this.ChatClose, 0);
            this.ChatClose.Size = new System.Drawing.Size(44, 46);
            this.ChatClose.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ChatClose.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ChatClose.SvgImage")));
            this.ChatClose.TabIndex = 1;
            this.ChatClose.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.ChatClose.Click += new System.EventHandler(this.ChatClose_Click);
            this.ChatClose.MouseEnter += new System.EventHandler(this.ChatClose_MouseEnter);
            this.ChatClose.MouseLeave += new System.EventHandler(this.ChatClose_MouseLeave);
            // 
            // SendMsgBtn
            // 
            this.tablePanel3.SetColumn(this.SendMsgBtn, 1);
            this.SendMsgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendMsgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendMsgBtn.Location = new System.Drawing.Point(264, 10);
            this.SendMsgBtn.Margin = new System.Windows.Forms.Padding(10);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.tablePanel3.SetRow(this.SendMsgBtn, 0);
            this.SendMsgBtn.Size = new System.Drawing.Size(86, 46);
            this.SendMsgBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.SendMsgBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SendMsgBtn.SvgImage")));
            this.SendMsgBtn.TabIndex = 0;
            this.SendMsgBtn.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.SendMsgBtn.Click += new System.EventHandler(this.chatButtonRight2_Click);
            this.SendMsgBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SendMsgBtn_MouseLeave);
            this.SendMsgBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SendMsgBtn_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChatForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 800);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ChatForm.IconOptions.Icon")));
            this.Name = "ChatForm";
            this.ShowInTaskbar = false;
            this.Text = "ChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatWnd_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePanels)).EndInit();
            this.TablePanels.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ScrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.tablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Booth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Support)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.General)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChatClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel ScrollPanel;
        private ReaLTaiizor.Controls.PoisonScrollBar SupportScroll;
        private ReaLTaiizor.Controls.Panel PSupport;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SvgImageBox SendMsgBtn;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SvgImageBox Support;
        private DevExpress.XtraEditors.SvgImageBox General;
        private DevExpress.Utils.Layout.TablePanel TablePanels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.Panel PGeneral;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.PoisonScrollBar GeneralScroll;
        private ReaLTaiizor.Controls.HopeRichTextBox ChatTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SvgImageBox ChatClose;
        private DevExpress.XtraEditors.SvgImageBox Booth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Panel PBooth;
        private ReaLTaiizor.Controls.PoisonScrollBar BoothScroll;
        private System.Windows.Forms.Panel panel3;
    }
}