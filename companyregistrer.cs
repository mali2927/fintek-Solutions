using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;


namespace fintek_Solutions
{
    public partial class companyregistrer : Form
    {
        public companyregistrer()
        {
            InitializeComponent();
        }
        int flag = 100;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet.Admin_company' table. You can move, or remove it, as needed.
            this.admin_companyTableAdapter.Fill(this.fintek_posDataSet.Admin_company);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void clear_feild()
        {
            txtcompanyname.Text = "";
            txtphoneno.Text = "";
            txtmobileno.Text = "";
            txtemail.Text = "";
            txtwebsite.Text = "";
            txtntnno.Text = "";
            txtstrn.Text = "";
            txtaddress.Text = "";

        }

        private void txtphoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!= 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
            }
        }

        private void txtmobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch!= '-')
            {
                e.Handled = true;
            }
        }
        
        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            if(Regex.IsMatch(txtemail.Text,pattern))
            {
                flag = 0;
                errorProvider1.Clear();
            }
            else
            {
                flag = 1;
                errorProvider1.SetError(this.txtemail, "Please Provide Valid Email Address");
                 
                return;
            }
        }

        private void txtntnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
                flag = 0;
            }
        }

        private void txtstrn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
                flag = 0;
            }
        }
        
        private void btnsave_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            
            SqlCommand sm = new SqlCommand("insert into Admin_company(C_name, C_phone, C_mobile, C_email, C_website, C_ntn, C_strn, C_Address)  values('" + txtcompanyname.Text + "','"+txtphoneno.Text+"','"+txtmobileno.Text+"','"+txtemail.Text+"','"+txtwebsite.Text+"','"+txtntnno.Text+"','"+txtstrn.Text+"','"+txtaddress.Text+"' )", sc);
            if (flag == 0)
            { 
                sc.Open();
           
            
                sm.ExecuteNonQuery();
                MessageBox.Show("Data saved Successfully");
                clear_feild();
                sc.Close();
                Dashboard dash = new Dashboard();
                dash.Show();
                
            }
            else
            {
                MessageBox.Show("Data did not save Please Enter Desire Information");
                sc.Close();
            }
            
           


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear_feild();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
