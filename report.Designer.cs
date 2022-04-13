namespace fintek_Solutions
{
    partial class report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fintek_posDataSet16 = new fintek_Solutions.fintek_posDataSet16();
            this.fintekposDataSet16BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtsearch = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fintek_posDataSet17 = new fintek_Solutions.fintek_posDataSet17();
            this.itemTableAdapter = new fintek_Solutions.fintek_posDataSet17TableAdapters.ItemTableAdapter();
            this.lblpursum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsalestock = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpdf = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintekposDataSet16BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(297, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // fintek_posDataSet16
            // 
            this.fintek_posDataSet16.DataSetName = "fintek_posDataSet16";
            this.fintek_posDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fintekposDataSet16BindingSource
            // 
            this.fintekposDataSet16BindingSource.DataSource = this.fintek_posDataSet16;
            this.fintekposDataSet16BindingSource.Position = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtsearch.FormattingEnabled = true;
            this.txtsearch.Location = new System.Drawing.Point(76, 40);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(180, 25);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.SelectedIndexChanged += new System.EventHandler(this.txtsearch_SelectedIndexChanged);
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtsearch_DragEnter);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.fintek_posDataSet17;
            // 
            // fintek_posDataSet17
            // 
            this.fintek_posDataSet17.DataSetName = "fintek_posDataSet17";
            this.fintek_posDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // lblpursum
            // 
            this.lblpursum.AutoSize = true;
            this.lblpursum.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpursum.Location = new System.Drawing.Point(193, 462);
            this.lblpursum.Name = "lblpursum";
            this.lblpursum.Size = new System.Drawing.Size(52, 17);
            this.lblpursum.TabIndex = 3;
            this.lblpursum.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Purchase Stock =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sale Stock =";
            // 
            // lblsalestock
            // 
            this.lblsalestock.AutoSize = true;
            this.lblsalestock.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestock.Location = new System.Drawing.Point(496, 462);
            this.lblsalestock.Name = "lblsalestock";
            this.lblsalestock.Size = new System.Drawing.Size(52, 17);
            this.lblsalestock.TabIndex = 3;
            this.lblsalestock.Text = "label1";
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(802, 462);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(52, 17);
            this.lblbalance.TabIndex = 3;
            this.lblbalance.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Balance =";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(359, 126);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(268, 298);
            this.dataGridView2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Purchase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sale";
            // 
            // btnpdf
            // 
            this.btnpdf.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.Location = new System.Drawing.Point(1001, 554);
            this.btnpdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(115, 53);
            this.btnpdf.TabIndex = 7;
            this.btnpdf.Text = "Generate PDF";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item Name";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 701);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsalestock);
            this.Controls.Add(this.lblpursum);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("CG Omega", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "report";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintekposDataSet16BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fintekposDataSet16BindingSource;
        private fintek_posDataSet16 fintek_posDataSet16;
        private System.Windows.Forms.ComboBox txtsearch;
        private fintek_posDataSet17 fintek_posDataSet17;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private fintek_posDataSet17TableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Label lblpursum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsalestock;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Label label6;
    }
}