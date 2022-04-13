namespace fintek_Solutions
{
    partial class Purchase_Invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtrefno = new System.Windows.Forms.TextBox();
            this.txtduedate = new System.Windows.Forms.DateTimePicker();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtvendor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fintek_posDataSet5 = new fintek_Solutions.fintek_posDataSet5();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtitem = new System.Windows.Forms.ComboBox();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fintek_posDataSet13 = new fintek_Solutions.fintek_posDataSet13();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtgst = new System.Windows.Forms.TextBox();
            this.txtgstamount = new System.Windows.Forms.TextBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fintek_posDataSet1 = new fintek_Solutions.fintek_posDataSet1();
            this.itemTableAdapter = new fintek_Solutions.fintek_posDataSet1TableAdapters.ItemTableAdapter();
            this.btnsaveandexit = new System.Windows.Forms.Button();
            this.btnsaveandconti = new System.Windows.Forms.Button();
            this.vendorTableAdapter = new fintek_Solutions.fintek_posDataSet5TableAdapters.VendorTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.itemTableAdapter1 = new fintek_Solutions.fintek_posDataSet13TableAdapters.ItemTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet1)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CG Omega", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "VENDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADDRESS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txtrefno);
            this.panel1.Controls.Add(this.txtduedate);
            this.panel1.Controls.Add(this.txtdate);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtvendor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 331);
            this.panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 282);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(617, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(601, 172);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 22);
            this.textBox3.TabIndex = 6;
            // 
            // txtrefno
            // 
            this.txtrefno.Location = new System.Drawing.Point(523, 87);
            this.txtrefno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtrefno.Name = "txtrefno";
            this.txtrefno.Size = new System.Drawing.Size(245, 22);
            this.txtrefno.TabIndex = 5;
            // 
            // txtduedate
            // 
            this.txtduedate.Location = new System.Drawing.Point(523, 254);
            this.txtduedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtduedate.Name = "txtduedate";
            this.txtduedate.Size = new System.Drawing.Size(245, 22);
            this.txtduedate.TabIndex = 4;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(523, 47);
            this.txtdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(245, 22);
            this.txtdate.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 136);
            this.textBox1.TabIndex = 3;
            // 
            // txtvendor
            // 
            this.txtvendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtvendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtvendor.FormattingEnabled = true;
            this.txtvendor.Location = new System.Drawing.Point(132, 46);
            this.txtvendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvendor.Name = "txtvendor";
            this.txtvendor.Size = new System.Drawing.Size(245, 24);
            this.txtvendor.TabIndex = 2;
            this.txtvendor.Enter += new System.EventHandler(this.txtvendor_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(451, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "BILL DUE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "AMOUNT DUE  PKR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "REF.No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "DATE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "DESCRIPTION";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.fintek_posDataSet5;
            // 
            // fintek_posDataSet5
            // 
            this.fintek_posDataSet5.DataSetName = "fintek_posDataSet5";
            this.fintek_posDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtitem);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.txtdescription);
            this.panel2.Controls.Add(this.txtrate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.txtamount);
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.txtgst);
            this.panel2.Controls.Add(this.txtgstamount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 423);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1341, 356);
            this.panel2.TabIndex = 1;
            // 
            // txtitem
            // 
            this.txtitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtitem.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.FormattingEnabled = true;
            this.txtitem.Location = new System.Drawing.Point(44, 21);
            this.txtitem.Margin = new System.Windows.Forms.Padding(4);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(107, 27);
            this.txtitem.TabIndex = 8;
            this.txtitem.Enter += new System.EventHandler(this.txtitem_Enter);
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "Item";
            this.itemBindingSource1.DataSource = this.fintek_posDataSet13;
            // 
            // fintek_posDataSet13
            // 
            this.fintek_posDataSet13.DataSetName = "fintek_posDataSet13";
            this.fintek_posDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(521, -2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Rate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(68, -2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "ITEM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(351, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Quanitity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(665, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(197, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(839, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "GST %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(999, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "GST Amount";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(337, 23);
            this.txtqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 27);
            this.txtqty.TabIndex = 9;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(195, 22);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(113, 27);
            this.txtdescription.TabIndex = 8;
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(505, 20);
            this.txtrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(100, 27);
            this.txtrate.TabIndex = 10;
            this.txtrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrate_KeyPress);
            this.txtrate.Leave += new System.EventHandler(this.txtrate_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1187, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.name,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1336, 293);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item.HeaderText = "ITEM";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            // 
            // name
            // 
            this.name.HeaderText = "Description";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "QTY";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RATE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "AMOUNT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GST %";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "GST AMOUNT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TOTAL";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(657, 20);
            this.txtamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 27);
            this.txtamount.TabIndex = 11;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(1169, 23);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 27);
            this.txttotal.TabIndex = 14;
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            // 
            // txtgst
            // 
            this.txtgst.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgst.Location = new System.Drawing.Point(820, 22);
            this.txtgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgst.Name = "txtgst";
            this.txtgst.Size = new System.Drawing.Size(100, 27);
            this.txtgst.TabIndex = 12;
            this.txtgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgst_KeyPress);
            this.txtgst.Leave += new System.EventHandler(this.txtgst_Leave);
            // 
            // txtgstamount
            // 
            this.txtgstamount.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgstamount.Location = new System.Drawing.Point(1003, 23);
            this.txtgstamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgstamount.Name = "txtgstamount";
            this.txtgstamount.Size = new System.Drawing.Size(100, 27);
            this.txtgstamount.TabIndex = 13;
            this.txtgstamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgstamount_KeyPress);
            this.txtgstamount.Leave += new System.EventHandler(this.txtgstamount_Leave);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.fintek_posDataSet1;
            // 
            // fintek_posDataSet1
            // 
            this.fintek_posDataSet1.DataSetName = "fintek_posDataSet1";
            this.fintek_posDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // btnsaveandexit
            // 
            this.btnsaveandexit.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveandexit.Location = new System.Drawing.Point(1128, 286);
            this.btnsaveandexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsaveandexit.Name = "btnsaveandexit";
            this.btnsaveandexit.Size = new System.Drawing.Size(184, 53);
            this.btnsaveandexit.TabIndex = 6;
            this.btnsaveandexit.Text = "Save and Exit";
            this.btnsaveandexit.UseVisualStyleBackColor = true;
            this.btnsaveandexit.Click += new System.EventHandler(this.btnsaveandexit_Click);
            // 
            // btnsaveandconti
            // 
            this.btnsaveandconti.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveandconti.Location = new System.Drawing.Point(884, 286);
            this.btnsaveandconti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsaveandconti.Name = "btnsaveandconti";
            this.btnsaveandconti.Size = new System.Drawing.Size(176, 53);
            this.btnsaveandconti.TabIndex = 5;
            this.btnsaveandconti.Text = "Next Item";
            this.btnsaveandconti.UseVisualStyleBackColor = true;
            this.btnsaveandconti.Click += new System.EventHandler(this.btnsaveandconti_Click);
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1341, 27);
            this.fillBy1ToolStrip.TabIndex = 7;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1341, 27);
            this.fillByToolStrip.TabIndex = 9;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // Purchase_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 779);
            this.Controls.Add(this.btnsaveandexit);
            this.Controls.Add(this.btnsaveandconti);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Purchase_Invoice";
            this.Text = "Purchase_Invoice";
            this.Load += new System.EventHandler(this.Purchase_Invoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet1)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrefno;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox txtvendor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker txtduedate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private fintek_posDataSet1 fintek_posDataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private fintek_posDataSet1TableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtgstamount;
        private System.Windows.Forms.TextBox txtgst;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button btnsaveandexit;
        private System.Windows.Forms.Button btnsaveandconti;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private fintek_posDataSet5 fintek_posDataSet5;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private fintek_posDataSet5TableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.ComboBox txtitem;
        private fintek_posDataSet13 fintek_posDataSet13;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private fintek_posDataSet13TableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}