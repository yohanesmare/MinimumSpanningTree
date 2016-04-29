namespace JarakTerdekat
{
    partial class MainWindow
    {
        
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_totalJarak = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_executionTime = new MaterialSkin.Controls.MaterialLabel();
            this.cb_algoritma = new System.Windows.Forms.ComboBox();
            this.btn_calculateMinSpanTree = new MaterialSkin.Controls.MaterialRaisedButton();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.but_generate = new System.Windows.Forms.Button();
            this.but_reload = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_deleteNode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_loadNodes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_nodeProperty = new System.Windows.Forms.Panel();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_deleteSelectedNode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_tambahTetangga = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox_neighbors = new System.Windows.Forms.ComboBox();
            this.listview_nodeNeighbors = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_saveNodes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_tambahNode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtField_nodeName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_help = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_about = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.cb_initialNode = new System.Windows.Forms.ComboBox();
            this.cb_endNode = new System.Windows.Forms.ComboBox();
            this.cpyRght = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_nodeProperty.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-3, 97);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1761, 89);
            this.materialTabSelector1.TabIndex = 19;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-3, 180);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1761, 734);
            this.materialTabControl1.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1753, 701);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Home";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1753, 701);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(488, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 648);
            this.panel3.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(304, 494);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(225, 50);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "YOHANES SIMARE MARE\r\n121401114";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(140, 554);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(546, 72);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "PROGRAM STUDI S-1 ILMU KOMPUTER\r\nFAKULTAS ILMU KOMPUTER DAN TEKNOLOGI INFORMASI\r\n" +
    "UNIVERSITAS SUMATERA UTARA";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(546, 98);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "IMPLEMENTASI DAN PERBANDINGAN ALGORITMA MINIMUM\r\nSPANNING TREE BORUVKA DAN PRIM D" +
    "ALAM\r\nOPTIMASI PANJANG JALUR LISTRIK DI\r\nUNIVERSITAS SUMATERA UTARA";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::JarakTerdekat.Properties.Resources.logo_usu_untuk_semua_png1;
            this.pictureBox1.Location = new System.Drawing.Point(273, 166);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 288);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialDivider4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.wpfHost);
            this.tabPage1.Controls.Add(this.but_generate);
            this.tabPage1.Controls.Add(this.but_reload);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1753, 701);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Process";
            // 
            // materialDivider4
            // 
            this.materialDivider4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(363, 17);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(2, 668);
            this.materialDivider4.TabIndex = 24;
            this.materialDivider4.TabStop = false;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_totalJarak);
            this.panel1.Controls.Add(this.lbl_executionTime);
            this.panel1.Controls.Add(this.cb_algoritma);
            this.panel1.Controls.Add(this.btn_calculateMinSpanTree);
            this.panel1.Location = new System.Drawing.Point(15, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 675);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Running Time : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total Jarak :";
            // 
            // lbl_totalJarak
            // 
            this.lbl_totalJarak.AutoSize = true;
            this.lbl_totalJarak.Depth = 0;
            this.lbl_totalJarak.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_totalJarak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_totalJarak.Location = new System.Drawing.Point(160, 143);
            this.lbl_totalJarak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalJarak.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_totalJarak.Name = "lbl_totalJarak";
            this.lbl_totalJarak.Size = new System.Drawing.Size(0, 27);
            this.lbl_totalJarak.TabIndex = 28;
            // 
            // lbl_executionTime
            // 
            this.lbl_executionTime.AutoSize = true;
            this.lbl_executionTime.Depth = 0;
            this.lbl_executionTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_executionTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_executionTime.Location = new System.Drawing.Point(160, 217);
            this.lbl_executionTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_executionTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_executionTime.Name = "lbl_executionTime";
            this.lbl_executionTime.Size = new System.Drawing.Size(0, 27);
            this.lbl_executionTime.TabIndex = 25;
            // 
            // cb_algoritma
            // 
            this.cb_algoritma.FormattingEnabled = true;
            this.cb_algoritma.Items.AddRange(new object[] {
            "Boruvka",
            "Prim"});
            this.cb_algoritma.Location = new System.Drawing.Point(16, 82);
            this.cb_algoritma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_algoritma.Name = "cb_algoritma";
            this.cb_algoritma.Size = new System.Drawing.Size(211, 28);
            this.cb_algoritma.TabIndex = 26;
            // 
            // btn_calculateMinSpanTree
            // 
            this.btn_calculateMinSpanTree.Depth = 0;
            this.btn_calculateMinSpanTree.Location = new System.Drawing.Point(238, 82);
            this.btn_calculateMinSpanTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calculateMinSpanTree.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_calculateMinSpanTree.Name = "btn_calculateMinSpanTree";
            this.btn_calculateMinSpanTree.Primary = true;
            this.btn_calculateMinSpanTree.Size = new System.Drawing.Size(69, 32);
            this.btn_calculateMinSpanTree.TabIndex = 23;
            this.btn_calculateMinSpanTree.Text = "Go";
            this.btn_calculateMinSpanTree.UseVisualStyleBackColor = true;
            this.btn_calculateMinSpanTree.Click += new System.EventHandler(this.btn_calculateMinSpanTree_Click);
            // 
            // wpfHost
            // 
            this.wpfHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(368, 5);
            this.wpfHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(1266, 680);
            this.wpfHost.TabIndex = 0;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.Child = null;
            // 
            // but_generate
            // 
            this.but_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_generate.Image = ((System.Drawing.Image)(resources.GetObject("but_generate.Image")));
            this.but_generate.Location = new System.Drawing.Point(1642, 9);
            this.but_generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_generate.Name = "but_generate";
            this.but_generate.Size = new System.Drawing.Size(98, 100);
            this.but_generate.TabIndex = 1;
            this.but_generate.UseVisualStyleBackColor = true;
            this.but_generate.Click += new System.EventHandler(this.but_generate_Click);
            // 
            // but_reload
            // 
            this.but_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_reload.Image = ((System.Drawing.Image)(resources.GetObject("but_reload.Image")));
            this.but_reload.Location = new System.Drawing.Point(1642, 118);
            this.but_reload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_reload.Name = "but_reload";
            this.but_reload.Size = new System.Drawing.Size(98, 100);
            this.but_reload.TabIndex = 2;
            this.but_reload.UseVisualStyleBackColor = true;
            this.but_reload.Click += new System.EventHandler(this.but_reload_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1753, 701);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Vertexs";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_deleteNode);
            this.panel5.Controls.Add(this.btn_loadNodes);
            this.panel5.Controls.Add(this.panel_nodeProperty);
            this.panel5.Controls.Add(this.btn_saveNodes);
            this.panel5.Controls.Add(this.materialDivider3);
            this.panel5.Controls.Add(this.materialDivider2);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.treeView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1745, 691);
            this.panel5.TabIndex = 1;
            // 
            // btn_deleteNode
            // 
            this.btn_deleteNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteNode.Depth = 0;
            this.btn_deleteNode.Location = new System.Drawing.Point(4, 637);
            this.btn_deleteNode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_deleteNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_deleteNode.Name = "btn_deleteNode";
            this.btn_deleteNode.Primary = true;
            this.btn_deleteNode.Size = new System.Drawing.Size(292, 42);
            this.btn_deleteNode.TabIndex = 37;
            this.btn_deleteNode.Text = "Delete";
            this.btn_deleteNode.UseVisualStyleBackColor = true;
            this.btn_deleteNode.Click += new System.EventHandler(this.btn_deleteNode_Click);
            // 
            // btn_loadNodes
            // 
            this.btn_loadNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadNodes.Depth = 0;
            this.btn_loadNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadNodes.Location = new System.Drawing.Point(1527, 651);
            this.btn_loadNodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_loadNodes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_loadNodes.Name = "btn_loadNodes";
            this.btn_loadNodes.Primary = true;
            this.btn_loadNodes.Size = new System.Drawing.Size(102, 35);
            this.btn_loadNodes.TabIndex = 25;
            this.btn_loadNodes.Text = "Load";
            this.btn_loadNodes.UseVisualStyleBackColor = true;
            this.btn_loadNodes.Click += new System.EventHandler(this.btn_loadNodes_Click);
            // 
            // panel_nodeProperty
            // 
            this.panel_nodeProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_nodeProperty.Controls.Add(this.materialDivider6);
            this.panel_nodeProperty.Controls.Add(this.btn_deleteSelectedNode);
            this.panel_nodeProperty.Controls.Add(this.materialDivider5);
            this.panel_nodeProperty.Controls.Add(this.btn_tambahTetangga);
            this.panel_nodeProperty.Controls.Add(this.comboBox_neighbors);
            this.panel_nodeProperty.Controls.Add(this.listview_nodeNeighbors);
            this.panel_nodeProperty.Location = new System.Drawing.Point(310, 0);
            this.panel_nodeProperty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_nodeProperty.Name = "panel_nodeProperty";
            this.panel_nodeProperty.Size = new System.Drawing.Size(561, 695);
            this.panel_nodeProperty.TabIndex = 22;
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(30, 625);
            this.materialDivider6.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(504, 2);
            this.materialDivider6.TabIndex = 36;
            this.materialDivider6.TabStop = false;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // btn_deleteSelectedNode
            // 
            this.btn_deleteSelectedNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteSelectedNode.Depth = 0;
            this.btn_deleteSelectedNode.Location = new System.Drawing.Point(20, 637);
            this.btn_deleteSelectedNode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_deleteSelectedNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_deleteSelectedNode.Name = "btn_deleteSelectedNode";
            this.btn_deleteSelectedNode.Primary = true;
            this.btn_deleteSelectedNode.Size = new System.Drawing.Size(514, 42);
            this.btn_deleteSelectedNode.TabIndex = 29;
            this.btn_deleteSelectedNode.Text = "Delete Neighbor";
            this.btn_deleteSelectedNode.UseVisualStyleBackColor = true;
            this.btn_deleteSelectedNode.Click += new System.EventHandler(this.btn_deleteSelectedNode_Click);
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(18, 72);
            this.materialDivider5.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(504, 2);
            this.materialDivider5.TabIndex = 35;
            this.materialDivider5.TabStop = false;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // btn_tambahTetangga
            // 
            this.btn_tambahTetangga.Depth = 0;
            this.btn_tambahTetangga.Location = new System.Drawing.Point(219, 25);
            this.btn_tambahTetangga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_tambahTetangga.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_tambahTetangga.Name = "btn_tambahTetangga";
            this.btn_tambahTetangga.Primary = true;
            this.btn_tambahTetangga.Size = new System.Drawing.Size(315, 34);
            this.btn_tambahTetangga.TabIndex = 30;
            this.btn_tambahTetangga.Text = "Add Neighbor";
            this.btn_tambahTetangga.UseVisualStyleBackColor = true;
            this.btn_tambahTetangga.Click += new System.EventHandler(this.btn_tambahTetangga_Click);
            // 
            // comboBox_neighbors
            // 
            this.comboBox_neighbors.FormattingEnabled = true;
            this.comboBox_neighbors.Location = new System.Drawing.Point(20, 26);
            this.comboBox_neighbors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_neighbors.Name = "comboBox_neighbors";
            this.comboBox_neighbors.Size = new System.Drawing.Size(180, 28);
            this.comboBox_neighbors.TabIndex = 33;
            // 
            // listview_nodeNeighbors
            // 
            this.listview_nodeNeighbors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_nodeNeighbors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listview_nodeNeighbors.Depth = 0;
            this.listview_nodeNeighbors.Font = new System.Drawing.Font("Roboto", 24F);
            this.listview_nodeNeighbors.FullRowSelect = true;
            this.listview_nodeNeighbors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_nodeNeighbors.Location = new System.Drawing.Point(30, 109);
            this.listview_nodeNeighbors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listview_nodeNeighbors.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listview_nodeNeighbors.MouseState = MaterialSkin.MouseState.OUT;
            this.listview_nodeNeighbors.Name = "listview_nodeNeighbors";
            this.listview_nodeNeighbors.OwnerDraw = true;
            this.listview_nodeNeighbors.RightToLeftLayout = true;
            this.listview_nodeNeighbors.Size = new System.Drawing.Size(492, 511);
            this.listview_nodeNeighbors.TabIndex = 28;
            this.listview_nodeNeighbors.UseCompatibleStateImageBehavior = false;
            this.listview_nodeNeighbors.View = System.Windows.Forms.View.Details;
            this.listview_nodeNeighbors.DoubleClick += new System.EventHandler(this.listview_nodeNeighbors_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tetangga";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jarak";
            this.columnHeader2.Width = 123;
            // 
            // btn_saveNodes
            // 
            this.btn_saveNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveNodes.Depth = 0;
            this.btn_saveNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveNodes.Location = new System.Drawing.Point(1639, 651);
            this.btn_saveNodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_saveNodes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_saveNodes.Name = "btn_saveNodes";
            this.btn_saveNodes.Primary = true;
            this.btn_saveNodes.Size = new System.Drawing.Size(102, 35);
            this.btn_saveNodes.TabIndex = 24;
            this.btn_saveNodes.Text = "Save";
            this.btn_saveNodes.UseVisualStyleBackColor = true;
            this.btn_saveNodes.Click += new System.EventHandler(this.btn_saveNodes_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(879, 26);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(2, 664);
            this.materialDivider3.TabIndex = 21;
            this.materialDivider3.TabStop = false;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(304, 25);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(2, 674);
            this.materialDivider2.TabIndex = 20;
            this.materialDivider2.TabStop = false;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.btn_tambahNode);
            this.panel4.Controls.Add(this.txtField_nodeName);
            this.panel4.Location = new System.Drawing.Point(882, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 681);
            this.panel4.TabIndex = 6;
            // 
            // btn_tambahNode
            // 
            this.btn_tambahNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tambahNode.Depth = 0;
            this.btn_tambahNode.Location = new System.Drawing.Point(354, 335);
            this.btn_tambahNode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_tambahNode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_tambahNode.Name = "btn_tambahNode";
            this.btn_tambahNode.Primary = true;
            this.btn_tambahNode.Size = new System.Drawing.Size(240, 52);
            this.btn_tambahNode.TabIndex = 1;
            this.btn_tambahNode.Text = "ADD Node";
            this.btn_tambahNode.UseVisualStyleBackColor = true;
            this.btn_tambahNode.Click += new System.EventHandler(this.btn_tambahNode_Click);
            // 
            // txtField_nodeName
            // 
            this.txtField_nodeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtField_nodeName.Depth = 0;
            this.txtField_nodeName.Hint = "Nama Node";
            this.txtField_nodeName.Location = new System.Drawing.Point(44, 291);
            this.txtField_nodeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtField_nodeName.MaxLength = 32767;
            this.txtField_nodeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtField_nodeName.Name = "txtField_nodeName";
            this.txtField_nodeName.PasswordChar = '\0';
            this.txtField_nodeName.SelectedText = "";
            this.txtField_nodeName.SelectionLength = 0;
            this.txtField_nodeName.SelectionStart = 0;
            this.txtField_nodeName.Size = new System.Drawing.Size(550, 32);
            this.txtField_nodeName.TabIndex = 3;
            this.txtField_nodeName.TabStop = false;
            this.txtField_nodeName.UseSystemPasswordChar = false;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.treeView1.Location = new System.Drawing.Point(4, 25);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(292, 601);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1753, 701);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.textBox_help);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1745, 691);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Petunjuk Penggunaan Sistem";
            // 
            // textBox_help
            // 
            this.textBox_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_help.BackColor = System.Drawing.Color.White;
            this.textBox_help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_help.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_help.Location = new System.Drawing.Point(249, 127);
            this.textBox_help.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_help.Multiline = true;
            this.textBox_help.Name = "textBox_help";
            this.textBox_help.ReadOnly = true;
            this.textBox_help.Size = new System.Drawing.Size(953, 545);
            this.textBox_help.TabIndex = 11;
            this.textBox_help.Text = resources.GetString("textBox_help.Text");
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel7);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Size = new System.Drawing.Size(1753, 701);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.textBox_about);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.textBox5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1745, 691);
            this.panel7.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::JarakTerdekat.Properties.Resources.Yohanes;
            this.pictureBox2.Location = new System.Drawing.Point(135, 206);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 385);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_about
            // 
            this.textBox_about.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_about.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_about.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_about.ForeColor = System.Drawing.Color.Black;
            this.textBox_about.Location = new System.Drawing.Point(513, 259);
            this.textBox_about.Multiline = true;
            this.textBox_about.Name = "textBox_about";
            this.textBox_about.Size = new System.Drawing.Size(711, 309);
            this.textBox_about.TabIndex = 14;
            this.textBox_about.Text = "\r\nNama    :  Yohanes Simare Mare\r\n\r\nNIM       : 121401114\r\n\r\nTTL        : Jakarta" +
    ", 19 Mei 1994\r\n\r\nEmail    : yohanesmaremare@gmail.com\r\n\r\nTelp       : 0822996087" +
    "84   ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 92);
            this.label1.TabIndex = 11;
            this.label1.Text = "IMPLEMENTASI DAN PERBANDINGAN ALGORITMA MINIMUM\r\nSPANNING TREE BORUVKA DAN PRIM D" +
    "ALAM\r\nOPTIMASI PANJANG JALUR LISTRIK DI\r\nUNIVERSITAS SUMATERA UTARA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox5.Location = new System.Drawing.Point(481, 231);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(779, 361);
            this.textBox5.TabIndex = 13;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-3, 922);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1762, 2);
            this.materialDivider1.TabIndex = 23;
            this.materialDivider1.TabStop = false;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // cb_initialNode
            // 
            this.cb_initialNode.FormattingEnabled = true;
            this.cb_initialNode.Location = new System.Drawing.Point(3, 938);
            this.cb_initialNode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_initialNode.Name = "cb_initialNode";
            this.cb_initialNode.Size = new System.Drawing.Size(26, 28);
            this.cb_initialNode.TabIndex = 25;
            this.cb_initialNode.Visible = false;
            // 
            // cb_endNode
            // 
            this.cb_endNode.FormattingEnabled = true;
            this.cb_endNode.Location = new System.Drawing.Point(40, 938);
            this.cb_endNode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_endNode.Name = "cb_endNode";
            this.cb_endNode.Size = new System.Drawing.Size(26, 28);
            this.cb_endNode.TabIndex = 30;
            this.cb_endNode.Visible = false;
            // 
            // cpyRght
            // 
            this.cpyRght.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpyRght.AutoSize = true;
            this.cpyRght.BackColor = System.Drawing.Color.Transparent;
            this.cpyRght.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpyRght.Location = new System.Drawing.Point(1580, 943);
            this.cpyRght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpyRght.Name = "cpyRght";
            this.cpyRght.Size = new System.Drawing.Size(0, 20);
            this.cpyRght.TabIndex = 31;
            this.cpyRght.Tag = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 989);
            this.Controls.Add(this.cpyRght);
            this.Controls.Add(this.cb_endNode);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cb_initialNode);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimum Spanning Tree";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_nodeProperty.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_calculateMinSpanTree;
        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button but_generate;
        private System.Windows.Forms.Button but_reload;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_nodeProperty;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialRaisedButton btn_deleteSelectedNode;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialRaisedButton btn_tambahTetangga;
        private System.Windows.Forms.ComboBox comboBox_neighbors;
        private MaterialSkin.Controls.MaterialListView listview_nodeNeighbors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRaisedButton btn_tambahNode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtField_nodeName;
        private System.Windows.Forms.TreeView treeView1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_saveNodes;
        private MaterialSkin.Controls.MaterialRaisedButton btn_loadNodes;
        private System.Windows.Forms.ComboBox cb_algoritma;
        private MaterialSkin.Controls.MaterialLabel lbl_executionTime;
        private MaterialSkin.Controls.MaterialRaisedButton btn_deleteNode;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel lbl_totalJarak;
        private System.Windows.Forms.ComboBox cb_endNode;
        private System.Windows.Forms.ComboBox cb_initialNode;
        private System.Windows.Forms.Label cpyRght;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_help;
        private System.Windows.Forms.TextBox textBox_about;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

