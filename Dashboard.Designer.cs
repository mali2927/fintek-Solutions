namespace fintek_Solutions
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstock = new System.Windows.Forms.Button();
            this.stockusercontrol1 = new fintek_Solutions.stockusercontrol();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnstock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnstock
            // 
            this.btnstock.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.Location = new System.Drawing.Point(0, 0);
            this.btnstock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(69, 38);
            this.btnstock.TabIndex = 0;
            this.btnstock.Text = "Stock";
            this.btnstock.UseVisualStyleBackColor = true;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // stockusercontrol1
            // 
            this.stockusercontrol1.Location = new System.Drawing.Point(0, 42);
            this.stockusercontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.stockusercontrol1.Name = "stockusercontrol1";
            this.stockusercontrol1.Size = new System.Drawing.Size(814, 606);
            this.stockusercontrol1.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 647);
            this.Controls.Add(this.stockusercontrol1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstock;
        private stockusercontrol stockusercontrol1;
    }
}