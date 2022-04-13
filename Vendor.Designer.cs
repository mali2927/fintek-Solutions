namespace fintek_Solutions
{
    partial class Vendor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcompanynameerror = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtstrn = new System.Windows.Forms.TextBox();
            this.txtntn = new System.Windows.Forms.TextBox();
            this.txtwebsite = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmobilenowork = new System.Windows.Forms.TextBox();
            this.txtmobilenommain = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorcontactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendormobileworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendormobilemainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendoremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendoraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorntnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorstrnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fintek_posDataSet8 = new fintek_Solutions.fintek_posDataSet8();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vendorTableAdapter = new fintek_Solutions.fintek_posDataSet8TableAdapters.VendorTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet8)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblcompanynameerror);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtstrn);
            this.panel1.Controls.Add(this.txtntn);
            this.panel1.Controls.Add(this.txtwebsite);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtmobilenowork);
            this.panel1.Controls.Add(this.txtmobilenommain);
            this.panel1.Controls.Add(this.txtfullname);
            this.panel1.Controls.Add(this.txtcompanyname);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 709);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblcompanynameerror
            // 
            this.lblcompanynameerror.AutoSize = true;
            this.lblcompanynameerror.Font = new System.Drawing.Font("CG Omega", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanynameerror.ForeColor = System.Drawing.Color.Red;
            this.lblcompanynameerror.Location = new System.Drawing.Point(575, 39);
            this.lblcompanynameerror.Name = "lblcompanynameerror";
            this.lblcompanynameerror.Size = new System.Drawing.Size(148, 36);
            this.lblcompanynameerror.TabIndex = 3;
            this.lblcompanynameerror.Text = "Enter Vendor Name\r\nFirst";
            this.lblcompanynameerror.Click += new System.EventHandler(this.lblcompanynameerror_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(501, 582);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(127, 39);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(95, 582);
            this.btnok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(127, 39);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "Save";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(249, 486);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(319, 70);
            this.txtaddress.TabIndex = 8;
            // 
            // txtstrn
            // 
            this.txtstrn.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstrn.Location = new System.Drawing.Point(249, 425);
            this.txtstrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstrn.Name = "txtstrn";
            this.txtstrn.Size = new System.Drawing.Size(319, 24);
            this.txtstrn.TabIndex = 7;
            this.txtstrn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstrn_KeyPress);
            // 
            // txtntn
            // 
            this.txtntn.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtntn.Location = new System.Drawing.Point(249, 382);
            this.txtntn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtntn.Name = "txtntn";
            this.txtntn.Size = new System.Drawing.Size(319, 24);
            this.txtntn.TabIndex = 6;
            this.txtntn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtntn_KeyPress);
            // 
            // txtwebsite
            // 
            this.txtwebsite.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwebsite.Location = new System.Drawing.Point(249, 327);
            this.txtwebsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtwebsite.Name = "txtwebsite";
            this.txtwebsite.Size = new System.Drawing.Size(319, 24);
            this.txtwebsite.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(249, 272);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(319, 24);
            this.txtemail.TabIndex = 4;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtmobilenowork
            // 
            this.txtmobilenowork.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobilenowork.Location = new System.Drawing.Point(249, 212);
            this.txtmobilenowork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmobilenowork.Name = "txtmobilenowork";
            this.txtmobilenowork.Size = new System.Drawing.Size(319, 24);
            this.txtmobilenowork.TabIndex = 3;
            this.txtmobilenowork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobilenowork_KeyPress);
            // 
            // txtmobilenommain
            // 
            this.txtmobilenommain.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobilenommain.Location = new System.Drawing.Point(249, 160);
            this.txtmobilenommain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmobilenommain.Name = "txtmobilenommain";
            this.txtmobilenommain.Size = new System.Drawing.Size(319, 24);
            this.txtmobilenommain.TabIndex = 2;
            this.txtmobilenommain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobilenommain_KeyPress);
            // 
            // txtfullname
            // 
            this.txtfullname.Font = new System.Drawing.Font("CG Omega", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.Location = new System.Drawing.Point(249, 111);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(319, 24);
            this.txtfullname.TabIndex = 1;
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyname.Location = new System.Drawing.Point(249, 30);
            this.txtcompanyname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcompanyname.Multiline = true;
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(319, 61);
            this.txtcompanyname.TabIndex = 0;
            this.txtcompanyname.Leave += new System.EventHandler(this.txtcompanyname_Leave);
            this.txtcompanyname.Validated += new System.EventHandler(this.txtcompanyname_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "STRN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "NTN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Website";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mobile No (Work)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile No (Main)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact Person Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendor  Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(791, 42);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(184, 28);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.Text = "Search";
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendornameDataGridViewTextBoxColumn,
            this.vendorcontactpersonDataGridViewTextBoxColumn,
            this.vendormobileworkDataGridViewTextBoxColumn,
            this.vendormobilemainDataGridViewTextBoxColumn,
            this.vendoremailDataGridViewTextBoxColumn,
            this.vendoraddressDataGridViewTextBoxColumn,
            this.vendorntnDataGridViewTextBoxColumn,
            this.vendorstrnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(781, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 394);
            this.dataGridView1.TabIndex = 3;
            // 
            // vendornameDataGridViewTextBoxColumn
            // 
            this.vendornameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vendornameDataGridViewTextBoxColumn.DataPropertyName = "Vendor_name";
            this.vendornameDataGridViewTextBoxColumn.HeaderText = "Vendor_name";
            this.vendornameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendornameDataGridViewTextBoxColumn.Name = "vendornameDataGridViewTextBoxColumn";
            this.vendornameDataGridViewTextBoxColumn.Width = 121;
            // 
            // vendorcontactpersonDataGridViewTextBoxColumn
            // 
            this.vendorcontactpersonDataGridViewTextBoxColumn.DataPropertyName = "Vendor_contact_person";
            this.vendorcontactpersonDataGridViewTextBoxColumn.HeaderText = "Vendor_contact_person";
            this.vendorcontactpersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendorcontactpersonDataGridViewTextBoxColumn.Name = "vendorcontactpersonDataGridViewTextBoxColumn";
            this.vendorcontactpersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendormobileworkDataGridViewTextBoxColumn
            // 
            this.vendormobileworkDataGridViewTextBoxColumn.DataPropertyName = "Vendor_mobile_work";
            this.vendormobileworkDataGridViewTextBoxColumn.HeaderText = "Vendor_mobile_work";
            this.vendormobileworkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendormobileworkDataGridViewTextBoxColumn.Name = "vendormobileworkDataGridViewTextBoxColumn";
            this.vendormobileworkDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendormobilemainDataGridViewTextBoxColumn
            // 
            this.vendormobilemainDataGridViewTextBoxColumn.DataPropertyName = "Vendor_mobile_main";
            this.vendormobilemainDataGridViewTextBoxColumn.HeaderText = "Vendor_mobile_main";
            this.vendormobilemainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendormobilemainDataGridViewTextBoxColumn.Name = "vendormobilemainDataGridViewTextBoxColumn";
            this.vendormobilemainDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendoremailDataGridViewTextBoxColumn
            // 
            this.vendoremailDataGridViewTextBoxColumn.DataPropertyName = "Vendor_email";
            this.vendoremailDataGridViewTextBoxColumn.HeaderText = "Vendor_email";
            this.vendoremailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendoremailDataGridViewTextBoxColumn.Name = "vendoremailDataGridViewTextBoxColumn";
            this.vendoremailDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendoraddressDataGridViewTextBoxColumn
            // 
            this.vendoraddressDataGridViewTextBoxColumn.DataPropertyName = "Vendor_address";
            this.vendoraddressDataGridViewTextBoxColumn.HeaderText = "Vendor_address";
            this.vendoraddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendoraddressDataGridViewTextBoxColumn.Name = "vendoraddressDataGridViewTextBoxColumn";
            this.vendoraddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendorntnDataGridViewTextBoxColumn
            // 
            this.vendorntnDataGridViewTextBoxColumn.DataPropertyName = "Vendor_ntn";
            this.vendorntnDataGridViewTextBoxColumn.HeaderText = "Vendor_ntn";
            this.vendorntnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendorntnDataGridViewTextBoxColumn.Name = "vendorntnDataGridViewTextBoxColumn";
            this.vendorntnDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendorstrnDataGridViewTextBoxColumn
            // 
            this.vendorstrnDataGridViewTextBoxColumn.DataPropertyName = "Vendor_strn";
            this.vendorstrnDataGridViewTextBoxColumn.HeaderText = "Vendor_strn";
            this.vendorstrnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendorstrnDataGridViewTextBoxColumn.Name = "vendorstrnDataGridViewTextBoxColumn";
            this.vendorstrnDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.fintek_posDataSet8;
            // 
            // fintek_posDataSet8
            // 
            this.fintek_posDataSet8.DataSetName = "fintek_posDataSet8";
            this.fintek_posDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1512, 27);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 731);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vendor";
            this.Text = "Vendor Details";
            this.Load += new System.EventHandler(this.Vendor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet8)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmobilenowork;
        private System.Windows.Forms.TextBox txtmobilenommain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtstrn;
        private System.Windows.Forms.TextBox txtntn;
        private System.Windows.Forms.TextBox txtwebsite;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblcompanynameerror;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private fintek_posDataSet8 fintek_posDataSet8;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private fintek_posDataSet8TableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorcontactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendormobileworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendormobilemainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendoremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendoraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorntnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorstrnDataGridViewTextBoxColumn;
    }
}