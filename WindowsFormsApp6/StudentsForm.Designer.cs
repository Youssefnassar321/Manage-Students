 namespace WindowsFormsApp6
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskDataSet = new WindowsFormsApp6.taskDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.schoolTableAdapter = new WindowsFormsApp6.taskDataSetTableAdapters.schoolTableAdapter();
            this.Messagelbl = new System.Windows.Forms.Label();
            this.Getbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Homebutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Addpage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Slidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menubutton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchimg = new System.Windows.Forms.PictureBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).BeginInit();
            this.Slidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchimg)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.id});
            this.dataGridView1.DataSource = this.schoolBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(764, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(345, 511);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "school";
            this.schoolBindingSource.DataSource = this.taskDataSet;
            // 
            // taskDataSet
            // 
            this.taskDataSet.DataSetName = "taskDataSet";
            this.taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(243, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 52);
            this.label1.TabIndex = 11;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(243, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 40);
            this.label2.TabIndex = 13;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(243, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 40);
            this.label3.TabIndex = 14;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Window;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(536, 172);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(190, 40);
            this.txt1.TabIndex = 15;
            this.txt1.Visible = false;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Addbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.Addbutton.Location = new System.Drawing.Point(257, 405);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(444, 72);
            this.Addbutton.TabIndex = 19;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Visible = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(536, 243);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(190, 40);
            this.txt2.TabIndex = 17;
            this.txt2.Visible = false;
            this.txt2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(536, 316);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(190, 40);
            this.txt3.TabIndex = 18;
            this.txt3.Visible = false;
            this.txt3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // Messagelbl
            // 
            this.Messagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Messagelbl.Location = new System.Drawing.Point(231, 622);
            this.Messagelbl.Name = "Messagelbl";
            this.Messagelbl.Size = new System.Drawing.Size(527, 40);
            this.Messagelbl.TabIndex = 21;
            this.Messagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Messagelbl.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Getbutton
            // 
            this.Getbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Getbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Getbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.Getbutton.Location = new System.Drawing.Point(257, 405);
            this.Getbutton.Name = "Getbutton";
            this.Getbutton.Size = new System.Drawing.Size(444, 72);
            this.Getbutton.TabIndex = 23;
            this.Getbutton.Text = "GET";
            this.Getbutton.UseVisualStyleBackColor = false;
            this.Getbutton.Visible = false;
            this.Getbutton.Click += new System.EventHandler(this.Getbutton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(291, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 54);
            this.label5.TabIndex = 24;
            this.label5.Text = "MTI || Manage Students";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Slidebar
            // 
            this.Slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Slidebar.Controls.Add(this.panel1);
            this.Slidebar.Controls.Add(this.panel3);
            this.Slidebar.Controls.Add(this.panel4);
            this.Slidebar.Controls.Add(this.panel6);
            this.Slidebar.Controls.Add(this.panel5);
            this.Slidebar.Controls.Add(this.panel9);
            this.Slidebar.Controls.Add(this.panel8);
            this.Slidebar.Location = new System.Drawing.Point(0, 62);
            this.Slidebar.MaximumSize = new System.Drawing.Size(222, 600);
            this.Slidebar.MinimumSize = new System.Drawing.Size(57, 600);
            this.Slidebar.Name = "Slidebar";
            this.Slidebar.Size = new System.Drawing.Size(222, 600);
            this.Slidebar.TabIndex = 26;
            this.Slidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Homebutton);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 66);
            this.panel1.TabIndex = 27;
            // 
            // Homebutton
            // 
            this.Homebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebutton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebutton.ForeColor = System.Drawing.Color.White;
            this.Homebutton.Image = ((System.Drawing.Image)(resources.GetObject("Homebutton.Image")));
            this.Homebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Homebutton.Location = new System.Drawing.Point(-18, 0);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Homebutton.Size = new System.Drawing.Size(200, 77);
            this.Homebutton.TabIndex = 23;
            this.Homebutton.Text = "     Home";
            this.Homebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Homebutton.UseVisualStyleBackColor = false;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Addpage);
            this.panel3.Location = new System.Drawing.Point(3, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 66);
            this.panel3.TabIndex = 28;
            // 
            // Addpage
            // 
            this.Addpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Addpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addpage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addpage.ForeColor = System.Drawing.Color.White;
            this.Addpage.Image = ((System.Drawing.Image)(resources.GetObject("Addpage.Image")));
            this.Addpage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addpage.Location = new System.Drawing.Point(-13, 0);
            this.Addpage.Name = "Addpage";
            this.Addpage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Addpage.Size = new System.Drawing.Size(200, 77);
            this.Addpage.TabIndex = 23;
            this.Addpage.Text = "      Add";
            this.Addpage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addpage.UseVisualStyleBackColor = false;
            this.Addpage.Click += new System.EventHandler(this.Addpage_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Refreshbutton);
            this.panel4.Location = new System.Drawing.Point(3, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 66);
            this.panel4.TabIndex = 29;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Refreshbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbutton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.ForeColor = System.Drawing.Color.White;
            this.Refreshbutton.Image = ((System.Drawing.Image)(resources.GetObject("Refreshbutton.Image")));
            this.Refreshbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refreshbutton.Location = new System.Drawing.Point(-11, 0);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Refreshbutton.Size = new System.Drawing.Size(200, 77);
            this.Refreshbutton.TabIndex = 23;
            this.Refreshbutton.Text = "     Refresh";
            this.Refreshbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refreshbutton.UseVisualStyleBackColor = false;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Helpbutton);
            this.panel6.Location = new System.Drawing.Point(3, 219);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 66);
            this.panel6.TabIndex = 28;
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helpbutton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.ForeColor = System.Drawing.Color.White;
            this.Helpbutton.Image = ((System.Drawing.Image)(resources.GetObject("Helpbutton.Image")));
            this.Helpbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Helpbutton.Location = new System.Drawing.Point(-19, 0);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Helpbutton.Size = new System.Drawing.Size(195, 76);
            this.Helpbutton.TabIndex = 23;
            this.Helpbutton.Text = "      Help";
            this.Helpbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Helpbutton.UseVisualStyleBackColor = false;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Searchbutton);
            this.panel5.Location = new System.Drawing.Point(3, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 66);
            this.panel5.TabIndex = 28;
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.ForeColor = System.Drawing.Color.White;
            this.Searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("Searchbutton.Image")));
            this.Searchbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbutton.Location = new System.Drawing.Point(-13, 0);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Searchbutton.Size = new System.Drawing.Size(200, 77);
            this.Searchbutton.TabIndex = 23;
            this.Searchbutton.Text = "     Search";
            this.Searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Registerbutton);
            this.panel8.Location = new System.Drawing.Point(3, 435);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(187, 66);
            this.panel8.TabIndex = 30;
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.Registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbutton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbutton.ForeColor = System.Drawing.Color.White;
            this.Registerbutton.Image = ((System.Drawing.Image)(resources.GetObject("Registerbutton.Image")));
            this.Registerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registerbutton.Location = new System.Drawing.Point(-18, 0);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Registerbutton.Size = new System.Drawing.Size(210, 77);
            this.Registerbutton.TabIndex = 23;
            this.Registerbutton.Text = "     Register";
            this.Registerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registerbutton.UseVisualStyleBackColor = false;
            this.Registerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Slidebartimer
            // 
            this.Slidebartimer.Interval = 10;
            this.Slidebartimer.Tick += new System.EventHandler(this.Slidebartimer_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.panel7.Controls.Add(this.CloseButton);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1116, 63);
            this.panel7.TabIndex = 27;
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(1054, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 54);
            this.CloseButton.TabIndex = 29;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.menubutton);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 62);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 40);
            this.label4.TabIndex = 27;
            this.label4.Text = "Menu";
            // 
            // menubutton
            // 
            this.menubutton.Image = ((System.Drawing.Image)(resources.GetObject("menubutton.Image")));
            this.menubutton.InitialImage = ((System.Drawing.Image)(resources.GetObject("menubutton.InitialImage")));
            this.menubutton.Location = new System.Drawing.Point(6, 2);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(50, 43);
            this.menubutton.TabIndex = 27;
            this.menubutton.TabStop = false;
            this.menubutton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(144, -59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 148);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, -93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 333);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.label6.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(418, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(467, 78);
            this.label6.TabIndex = 32;
            this.label6.Text = "Welcome To MTI";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.label7.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(359, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(592, 145);
            this.label7.TabIndex = 33;
            this.label7.Text = "Student management\r\n           Form App \r\n";
            // 
            // searchimg
            // 
            this.searchimg.Image = ((System.Drawing.Image)(resources.GetObject("searchimg.Image")));
            this.searchimg.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchimg.InitialImage")));
            this.searchimg.Location = new System.Drawing.Point(1064, 101);
            this.searchimg.Name = "searchimg";
            this.searchimg.Size = new System.Drawing.Size(44, 41);
            this.searchimg.TabIndex = 30;
            this.searchimg.TabStop = false;
            this.searchimg.Visible = false;
            this.searchimg.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.SystemColors.Window;
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(764, 104);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(304, 38);
            this.searchbox.TabIndex = 34;
            this.searchbox.Visible = false;
            this.searchbox.ReadOnlyChanged += new System.EventHandler(this.searchbox_ReadOnlyChanged);
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            this.searchbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbox_KeyPress);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button1);
            this.panel9.Location = new System.Drawing.Point(3, 363);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(187, 66);
            this.panel9.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-18, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(210, 77);
            this.button1.TabIndex = 23;
            this.button1.Text = "     Degrees";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(194)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(1115, 661);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.searchimg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Slidebar);
            this.Controls.Add(this.Getbutton);
            this.Controls.Add(this.Messagelbl);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).EndInit();
            this.Slidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchimg)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private taskDataSet taskDataSet;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private taskDataSetTableAdapters.schoolTableAdapter schoolTableAdapter;
        private System.Windows.Forms.Label Messagelbl;
        private System.Windows.Forms.Button Getbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel Slidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Homebutton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Addpage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Timer Slidebartimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox menubutton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.PictureBox searchimg;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
    }
}

