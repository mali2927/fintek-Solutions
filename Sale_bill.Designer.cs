namespace fintek_Solutions
{
    partial class Sale_bill
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
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsaveandconti = new System.Windows.Forms.Button();
            this.btnsaveandexit = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtgst = new System.Windows.Forms.TextBox();
            this.txtgstamount = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fintek_posDataSet16 = new fintek_Solutions.fintek_posDataSet16();
            this.itemTableAdapter = new fintek_Solutions.fintek_posDataSet16TableAdapters.ItemTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txtinvoiceno);
            this.panel1.Controls.Add(this.txtdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 201);
            this.panel1.TabIndex = 0;
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(1023, 119);
            this.txtinvoiceno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(200, 22);
            this.txtinvoiceno.TabIndex = 2;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(1023, 55);
            this.txtdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 22);
            this.txtdate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(917, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Invoice No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(917, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CG Omega", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 425);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1293, 277);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.item.HeaderText = "ITEM";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            this.item.Width = 68;
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
            // btnsaveandconti
            // 
            this.btnsaveandconti.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveandconti.Location = new System.Drawing.Point(891, 292);
            this.btnsaveandconti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsaveandconti.Name = "btnsaveandconti";
            this.btnsaveandconti.Size = new System.Drawing.Size(181, 52);
            this.btnsaveandconti.TabIndex = 2;
            this.btnsaveandconti.Text = "Next Item";
            this.btnsaveandconti.UseVisualStyleBackColor = true;
            this.btnsaveandconti.Click += new System.EventHandler(this.btnsaveandconti_Click);
            // 
            // btnsaveandexit
            // 
            this.btnsaveandexit.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveandexit.Location = new System.Drawing.Point(1105, 292);
            this.btnsaveandexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsaveandexit.Name = "btnsaveandexit";
            this.btnsaveandexit.Size = new System.Drawing.Size(173, 52);
            this.btnsaveandexit.TabIndex = 2;
            this.btnsaveandexit.Text = "Save and Exit";
            this.btnsaveandexit.UseVisualStyleBackColor = true;
            this.btnsaveandexit.Click += new System.EventHandler(this.btnsaveandexit_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(176, 386);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(113, 26);
            this.txtdescription.TabIndex = 1;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(315, 385);
            this.txtqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 27);
            this.txtqty.TabIndex = 2;
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(484, 385);
            this.txtrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(100, 27);
            this.txtrate.TabIndex = 3;
            this.txtrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrate_KeyPress);
            this.txtrate.Leave += new System.EventHandler(this.txtrate_Leave);
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(647, 388);
            this.txtamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 27);
            this.txtamount.TabIndex = 4;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // txtgst
            // 
            this.txtgst.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgst.Location = new System.Drawing.Point(804, 388);
            this.txtgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgst.Name = "txtgst";
            this.txtgst.Size = new System.Drawing.Size(100, 27);
            this.txtgst.TabIndex = 5;
            this.txtgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgst_KeyPress);
            this.txtgst.Leave += new System.EventHandler(this.txtgst_Leave);
            // 
            // txtgstamount
            // 
            this.txtgstamount.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgstamount.Location = new System.Drawing.Point(971, 386);
            this.txtgstamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgstamount.Name = "txtgstamount";
            this.txtgstamount.Size = new System.Drawing.Size(100, 27);
            this.txtgstamount.TabIndex = 6;
            this.txtgstamount.Leave += new System.EventHandler(this.txtgstamount_Leave);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(1155, 383);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 27);
            this.txttotal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ITEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quanitity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(507, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(655, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(823, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "GST %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(971, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "GST Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1172, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Total";
            // 
            // txtitem
            // 
            this.txtitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtitem.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.FormattingEnabled = true;
            this.txtitem.Location = new System.Drawing.Point(67, 386);
            this.txtitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(84, 27);
            this.txtitem.TabIndex = 0;
            this.txtitem.Enter += new System.EventHandler(this.txtitem_Enter);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.fintek_posDataSet16;
            // 
            // fintek_posDataSet16
            // 
            this.fintek_posDataSet16.DataSetName = "fintek_posDataSet16";
            this.fintek_posDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // Sale_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 729);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtgstamount);
            this.Controls.Add(this.txtgst);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.btnsaveandexit);
            this.Controls.Add(this.btnsaveandconti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sale_bill";
            this.Text = "Sale_bill";
            this.Load += new System.EventHandler(this.Sale_bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsaveandconti;
        private System.Windows.Forms.Button btnsaveandexit;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtgst;
        private System.Windows.Forms.TextBox txtgstamount;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtitem;
        private fintek_posDataSet16 fintek_posDataSet16;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private fintek_posDataSet16TableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}