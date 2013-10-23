namespace AssetBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataFileListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.extractDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.data2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.data3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.data4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.selectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(740, 393);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataFileListBox
            // 
            this.dataFileListBox.ContextMenuStrip = this.contextMenuStrip2;
            this.dataFileListBox.FormattingEnabled = true;
            this.dataFileListBox.Location = new System.Drawing.Point(321, 113);
            this.dataFileListBox.Name = "dataFileListBox";
            this.dataFileListBox.Size = new System.Drawing.Size(130, 69);
            this.dataFileListBox.TabIndex = 0;
            this.dataFileListBox.SelectedIndexChanged += new System.EventHandler(this.dataFileListBox_SelectedIndexChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.toolStripSeparator1,
            this.extractDataToolStripMenuItem,
            this.insertDataToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(136, 76);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Enabled = false;
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nameToolStripMenuItem.Text = "[]";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // extractDataToolStripMenuItem
            // 
            this.extractDataToolStripMenuItem.Name = "extractDataToolStripMenuItem";
            this.extractDataToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.extractDataToolStripMenuItem.Text = "Extract data";
            // 
            // insertDataToolStripMenuItem
            // 
            this.insertDataToolStripMenuItem.Name = "insertDataToolStripMenuItem";
            this.insertDataToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.insertDataToolStripMenuItem.Text = "Insert data";
            this.insertDataToolStripMenuItem.Click += new System.EventHandler(this.insertDataToolStripMenuItem_Click);
            // 
            // assetListView
            // 
            this.assetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.assetListView.ContextMenuStrip = this.contextMenuStrip1;
            this.assetListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assetListView.FullRowSelect = true;
            this.assetListView.GridLines = true;
            this.assetListView.Location = new System.Drawing.Point(6, 6);
            this.assetListView.Name = "assetListView";
            this.assetListView.Size = new System.Drawing.Size(731, 283);
            this.assetListView.TabIndex = 0;
            this.assetListView.UseCompatibleStateImageBehavior = false;
            this.assetListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 116;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNameMenuItem,
            this.toolStripMenuItem1,
            this.extractToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // fileNameMenuItem
            // 
            this.fileNameMenuItem.Enabled = false;
            this.fileNameMenuItem.Name = "fileNameMenuItem";
            this.fileNameMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fileNameMenuItem.Text = "[]";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 319);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.assetListView);
            this.tabPage1.Controls.Add(this.dataFileListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(743, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(9, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(726, 20);
            this.textBox1.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(727, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(727, 225);
            this.listBox1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.progressBar2);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(743, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extract files";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(9, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(726, 20);
            this.textBox2.TabIndex = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(8, 264);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(727, 23);
            this.progressBar2.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(8, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(727, 225);
            this.listBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(702, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ".ReFleX";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShowShortcutKeys = false;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data1ToolStripMenuItem,
            this.toolStripSeparator3,
            this.data2ToolStripMenuItem,
            this.toolStripSeparator5,
            this.data3ToolStripMenuItem,
            this.toolStripSeparator6,
            this.data4ToolStripMenuItem});
            this.selectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectToolStripMenuItem.Image")));
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.selectToolStripMenuItem.Text = "Data";
            this.selectToolStripMenuItem.Visible = false;
            // 
            // data1ToolStripMenuItem
            // 
            this.data1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.decompileToolStripMenuItem,
            this.compileToolStripMenuItem});
            this.data1ToolStripMenuItem.Enabled = false;
            this.data1ToolStripMenuItem.Name = "data1ToolStripMenuItem";
            this.data1ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.data1ToolStripMenuItem.Text = "data1";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readToolStripMenuItem.Image")));
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.readToolStripMenuItem.Text = "View";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // decompileToolStripMenuItem
            // 
            this.decompileToolStripMenuItem.Enabled = false;
            this.decompileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decompileToolStripMenuItem.Image")));
            this.decompileToolStripMenuItem.Name = "decompileToolStripMenuItem";
            this.decompileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.decompileToolStripMenuItem.Text = "Extract files";
            this.decompileToolStripMenuItem.Click += new System.EventHandler(this.decompileToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compileToolStripMenuItem.Image")));
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.compileToolStripMenuItem.Text = "Add files";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // data2ToolStripMenuItem
            // 
            this.data2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem1,
            this.decompileToolStripMenuItem1,
            this.compileToolStripMenuItem1});
            this.data2ToolStripMenuItem.Enabled = false;
            this.data2ToolStripMenuItem.Name = "data2ToolStripMenuItem";
            this.data2ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.data2ToolStripMenuItem.Text = "data2";
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("readToolStripMenuItem1.Image")));
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.readToolStripMenuItem1.Text = "View";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // decompileToolStripMenuItem1
            // 
            this.decompileToolStripMenuItem1.Enabled = false;
            this.decompileToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("decompileToolStripMenuItem1.Image")));
            this.decompileToolStripMenuItem1.Name = "decompileToolStripMenuItem1";
            this.decompileToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.decompileToolStripMenuItem1.Text = "Extract files";
            this.decompileToolStripMenuItem1.Click += new System.EventHandler(this.decompileToolStripMenuItem1_Click);
            // 
            // compileToolStripMenuItem1
            // 
            this.compileToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("compileToolStripMenuItem1.Image")));
            this.compileToolStripMenuItem1.Name = "compileToolStripMenuItem1";
            this.compileToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.compileToolStripMenuItem1.Text = "Add files";
            this.compileToolStripMenuItem1.Click += new System.EventHandler(this.compileToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(100, 6);
            // 
            // data3ToolStripMenuItem
            // 
            this.data3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem2,
            this.decompileToolStripMenuItem2,
            this.compileToolStripMenuItem2});
            this.data3ToolStripMenuItem.Enabled = false;
            this.data3ToolStripMenuItem.Name = "data3ToolStripMenuItem";
            this.data3ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.data3ToolStripMenuItem.Text = "data3";
            // 
            // readToolStripMenuItem2
            // 
            this.readToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("readToolStripMenuItem2.Image")));
            this.readToolStripMenuItem2.Name = "readToolStripMenuItem2";
            this.readToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.readToolStripMenuItem2.Text = "View";
            this.readToolStripMenuItem2.Click += new System.EventHandler(this.readToolStripMenuItem2_Click);
            // 
            // decompileToolStripMenuItem2
            // 
            this.decompileToolStripMenuItem2.Enabled = false;
            this.decompileToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("decompileToolStripMenuItem2.Image")));
            this.decompileToolStripMenuItem2.Name = "decompileToolStripMenuItem2";
            this.decompileToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.decompileToolStripMenuItem2.Text = "Extract files";
            this.decompileToolStripMenuItem2.Click += new System.EventHandler(this.decompileToolStripMenuItem2_Click);
            // 
            // compileToolStripMenuItem2
            // 
            this.compileToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("compileToolStripMenuItem2.Image")));
            this.compileToolStripMenuItem2.Name = "compileToolStripMenuItem2";
            this.compileToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.compileToolStripMenuItem2.Text = "Add files";
            this.compileToolStripMenuItem2.Click += new System.EventHandler(this.compileToolStripMenuItem2_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(100, 6);
            // 
            // data4ToolStripMenuItem
            // 
            this.data4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem3,
            this.decompileToolStripMenuItem3,
            this.compileToolStripMenuItem3});
            this.data4ToolStripMenuItem.Enabled = false;
            this.data4ToolStripMenuItem.Name = "data4ToolStripMenuItem";
            this.data4ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.data4ToolStripMenuItem.Text = "data4";
            // 
            // readToolStripMenuItem3
            // 
            this.readToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("readToolStripMenuItem3.Image")));
            this.readToolStripMenuItem3.Name = "readToolStripMenuItem3";
            this.readToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.readToolStripMenuItem3.Text = "View";
            this.readToolStripMenuItem3.Click += new System.EventHandler(this.readToolStripMenuItem3_Click);
            // 
            // decompileToolStripMenuItem3
            // 
            this.decompileToolStripMenuItem3.Enabled = false;
            this.decompileToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("decompileToolStripMenuItem3.Image")));
            this.decompileToolStripMenuItem3.Name = "decompileToolStripMenuItem3";
            this.decompileToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.decompileToolStripMenuItem3.Text = "Extract files";
            this.decompileToolStripMenuItem3.Click += new System.EventHandler(this.decompileToolStripMenuItem3_Click);
            // 
            // compileToolStripMenuItem3
            // 
            this.compileToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("compileToolStripMenuItem3.Image")));
            this.compileToolStripMenuItem3.Name = "compileToolStripMenuItem3";
            this.compileToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.compileToolStripMenuItem3.Text = "Add files";
            this.compileToolStripMenuItem3.Click += new System.EventHandler(this.compileToolStripMenuItem3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 336);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skins Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView assetListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileNameMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListBox dataFileListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem extractDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertDataToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem data1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem data2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decompileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem data3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decompileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem data4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decompileToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}