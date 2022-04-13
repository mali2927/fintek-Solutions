namespace fintek_Solutions
{
    partial class Inventory
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
            this.fintek_posDataSet14 = new fintek_Solutions.fintek_posDataSet14();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new fintek_Solutions.fintek_posDataSet14TableAdapters.InventoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fintek_posDataSet15 = new fintek_Solutions.fintek_posDataSet15();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter1 = new fintek_Solutions.fintek_posDataSet15TableAdapters.InventoryTableAdapter();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fintek_posDataSet14
            // 
            this.fintek_posDataSet14.DataSetName = "fintek_posDataSet14";
            this.fintek_posDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.fintek_posDataSet14;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemnameDataGridViewTextBoxColumn,
            this.itemcategoryDataGridViewTextBoxColumn,
            this.itemquantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(128, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // fintek_posDataSet15
            // 
            this.fintek_posDataSet15.DataSetName = "fintek_posDataSet15";
            this.fintek_posDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.fintek_posDataSet15;
            // 
            // inventoryTableAdapter1
            // 
            this.inventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "Item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "Item_name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // itemcategoryDataGridViewTextBoxColumn
            // 
            this.itemcategoryDataGridViewTextBoxColumn.DataPropertyName = "Item_category";
            this.itemcategoryDataGridViewTextBoxColumn.HeaderText = "Item_category";
            this.itemcategoryDataGridViewTextBoxColumn.Name = "itemcategoryDataGridViewTextBoxColumn";
            // 
            // itemquantityDataGridViewTextBoxColumn
            // 
            this.itemquantityDataGridViewTextBoxColumn.DataPropertyName = "Item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.HeaderText = "Item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.Name = "itemquantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(270, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CG Omega", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private fintek_posDataSet14 fintek_posDataSet14;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private fintek_posDataSet14TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fintek_posDataSet15 fintek_posDataSet15;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private fintek_posDataSet15TableAdapters.InventoryTableAdapter inventoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}