namespace fintek_Solutions
{
    partial class companyregistrer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companyregistrer));
            this.logo = new System.Windows.Forms.PictureBox();
            this.company_name = new System.Windows.Forms.Label();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.lblphoneno = new System.Windows.Forms.Label();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.lblmobileno = new System.Windows.Forms.Label();
            this.txtntnno = new System.Windows.Forms.TextBox();
            this.lblntnno = new System.Windows.Forms.Label();
            this.txtstrn = new System.Windows.Forms.TextBox();
            this.lblstrn = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtwebsite = new System.Windows.Forms.TextBox();
            this.lblwebsite = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fintek_posDataSet = new fintek_Solutions.fintek_posDataSet();
            this.admincompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_companyTableAdapter = new fintek_Solutions.fintek_posDataSetTableAdapters.Admin_companyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admincompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(111, 167);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // company_name
            // 
            this.company_name.AutoSize = true;
            this.company_name.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_name.Location = new System.Drawing.Point(160, 70);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(151, 24);
            this.company_name.TabIndex = 1;
            this.company_name.Text = "Company Name";
            this.company_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.company_name.UseMnemonic = false;
            this.company_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyname.Location = new System.Drawing.Point(331, 65);
            this.txtcompanyname.Multiline = true;
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(304, 54);
            this.txtcompanyname.TabIndex = 0;
            this.txtcompanyname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(331, 474);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(304, 86);
            this.txtaddress.TabIndex = 7;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(160, 479);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(78, 24);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Address";
            this.lbladdress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbladdress.UseMnemonic = false;
            // 
            // txtphoneno
            // 
            this.txtphoneno.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneno.Location = new System.Drawing.Point(331, 147);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(304, 32);
            this.txtphoneno.TabIndex = 1;
            this.txtphoneno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtphoneno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphoneno_KeyPress);
            // 
            // lblphoneno
            // 
            this.lblphoneno.AutoSize = true;
            this.lblphoneno.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneno.Location = new System.Drawing.Point(160, 152);
            this.lblphoneno.Name = "lblphoneno";
            this.lblphoneno.Size = new System.Drawing.Size(107, 24);
            this.lblphoneno.TabIndex = 5;
            this.lblphoneno.Text = "Phone No#";
            this.lblphoneno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblphoneno.UseMnemonic = false;
            this.lblphoneno.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtmobileno
            // 
            this.txtmobileno.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.Location = new System.Drawing.Point(331, 193);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(304, 32);
            this.txtmobileno.TabIndex = 2;
            this.txtmobileno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobileno_KeyPress);
            // 
            // lblmobileno
            // 
            this.lblmobileno.AutoSize = true;
            this.lblmobileno.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobileno.Location = new System.Drawing.Point(160, 198);
            this.lblmobileno.Name = "lblmobileno";
            this.lblmobileno.Size = new System.Drawing.Size(115, 24);
            this.lblmobileno.TabIndex = 7;
            this.lblmobileno.Text = "Mobile No#";
            this.lblmobileno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmobileno.UseMnemonic = false;
            // 
            // txtntnno
            // 
            this.txtntnno.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtntnno.Location = new System.Drawing.Point(331, 342);
            this.txtntnno.Name = "txtntnno";
            this.txtntnno.Size = new System.Drawing.Size(304, 32);
            this.txtntnno.TabIndex = 5;
            this.txtntnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtntnno_KeyPress);
            // 
            // lblntnno
            // 
            this.lblntnno.AutoSize = true;
            this.lblntnno.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblntnno.Location = new System.Drawing.Point(160, 347);
            this.lblntnno.Name = "lblntnno";
            this.lblntnno.Size = new System.Drawing.Size(62, 24);
            this.lblntnno.TabIndex = 9;
            this.lblntnno.Text = "NTN#";
            this.lblntnno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblntnno.UseMnemonic = false;
            // 
            // txtstrn
            // 
            this.txtstrn.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstrn.Location = new System.Drawing.Point(331, 403);
            this.txtstrn.Name = "txtstrn";
            this.txtstrn.Size = new System.Drawing.Size(304, 32);
            this.txtstrn.TabIndex = 6;
            this.txtstrn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstrn_KeyPress);
            // 
            // lblstrn
            // 
            this.lblstrn.AutoSize = true;
            this.lblstrn.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstrn.Location = new System.Drawing.Point(161, 403);
            this.lblstrn.Name = "lblstrn";
            this.lblstrn.Size = new System.Drawing.Size(58, 24);
            this.lblstrn.TabIndex = 11;
            this.lblstrn.Text = "STRN";
            this.lblstrn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblstrn.UseMnemonic = false;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(331, 243);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(304, 32);
            this.txtemail.TabIndex = 3;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(160, 248);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(59, 24);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "Email";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblemail.UseMnemonic = false;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnclear.Location = new System.Drawing.Point(597, 599);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(122, 55);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsave.Location = new System.Drawing.Point(145, 599);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(122, 55);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtwebsite
            // 
            this.txtwebsite.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwebsite.Location = new System.Drawing.Point(331, 293);
            this.txtwebsite.Name = "txtwebsite";
            this.txtwebsite.Size = new System.Drawing.Size(304, 32);
            this.txtwebsite.TabIndex = 4;
            // 
            // lblwebsite
            // 
            this.lblwebsite.AutoSize = true;
            this.lblwebsite.Font = new System.Drawing.Font("CG Omega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwebsite.Location = new System.Drawing.Point(160, 298);
            this.lblwebsite.Name = "lblwebsite";
            this.lblwebsite.Size = new System.Drawing.Size(81, 24);
            this.lblwebsite.TabIndex = 27;
            this.lblwebsite.Text = "Website";
            this.lblwebsite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblwebsite.UseMnemonic = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fintek_posDataSet
            // 
            this.fintek_posDataSet.DataSetName = "fintek_posDataSet";
            this.fintek_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admincompanyBindingSource
            // 
            this.admincompanyBindingSource.DataMember = "Admin_company";
            this.admincompanyBindingSource.DataSource = this.fintek_posDataSet;
            // 
            // admin_companyTableAdapter
            // 
            this.admin_companyTableAdapter.ClearBeforeFill = true;
            // 
            // companyregistrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 701);
            this.Controls.Add(this.txtwebsite);
            this.Controls.Add(this.lblwebsite);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtstrn);
            this.Controls.Add(this.lblstrn);
            this.Controls.Add(this.txtntnno);
            this.Controls.Add(this.lblntnno);
            this.Controls.Add(this.txtmobileno);
            this.Controls.Add(this.lblmobileno);
            this.Controls.Add(this.txtphoneno);
            this.Controls.Add(this.lblphoneno);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtcompanyname);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.logo);
            this.Name = "companyregistrer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fintek_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admincompanyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.Label lblphoneno;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.Label lblmobileno;
        private System.Windows.Forms.TextBox txtntnno;
        private System.Windows.Forms.Label lblntnno;
        private System.Windows.Forms.TextBox txtstrn;
        private System.Windows.Forms.Label lblstrn;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtwebsite;
        private System.Windows.Forms.Label lblwebsite;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private fintek_posDataSet fintek_posDataSet;
        private System.Windows.Forms.BindingSource admincompanyBindingSource;
        private fintek_posDataSetTableAdapters.Admin_companyTableAdapter admin_companyTableAdapter;
    }
}

