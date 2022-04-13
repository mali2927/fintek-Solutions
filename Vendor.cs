using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fintek_Solutions
{
    public partial class Vendor : Form
    {
        public Vendor()
        {
           
            InitializeComponent();
            lblcompanynameerror.Visible = false;
        }
        int flag = 100;
        void clear_feilds()
        {
            txtcompanyname.Text = "";
            txtfullname.Text = "";
            txtmobilenommain.Text = "";
            txtmobilenowork.Text = "";
            txtemail.Text = "";
            txtwebsite.Text = "";
            txtntn.Text = "";
            txtstrn.Text = "";
            txtaddress.Text = "";
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            if (Regex.IsMatch(txtemail.Text, pattern))
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
         
        private void txtmobilenommain_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
                flag = 0;
            }
           
        }

        private void txtmobilenowork_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
                flag = 0;
            }
           
        }

        private void txtntn_KeyPress(object sender, KeyPressEventArgs e)
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
            else
            {
                flag = -1;
            }

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);

            SqlCommand cmd = new SqlCommand("select * from Vendor where Vendor_name=@name", sc);
            cmd.Parameters.AddWithValue("name", txtcompanyname.Text.Trim());
            sc.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                MessageBox.Show("Duplicate Vendor Name Can not be inserted Please Try a Different Name");
                sdr.Close();
                sc.Close();

            }
            else
            {
                SqlCommand sm = new SqlCommand("insert into Vendor(Vendor_name, Vendor_contact_person, Vendor_mobile_main, Vendor_mobile_work, Vendor_email, Vendor_website, Vendor_ntn, Vendor_strn, Vendor_address)  values('" + txtcompanyname.Text + "','" + txtfullname.Text + "','" + txtmobilenommain.Text + "','" + txtmobilenowork.Text + "','" + txtemail.Text + "','" + txtwebsite.Text + "','" + txtntn.Text + "','" + txtstrn.Text + "','" + txtaddress.Text + "' )", sc);
               
                
                    try
                    {
                       
                        sm.ExecuteNonQuery();
                        MessageBox.Show("Data saved Successfully");
                        clear_feilds();
                       
                        this.Close();
                        Dashboard dash = new Dashboard();
                        dash.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                       
                    }
                sc.Close();
                
            }


            this.Close();




            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcompanyname_Validated(object sender, EventArgs e)
        {
            if(txtcompanyname.Text==String.Empty)
            {
                btnok.Visible = false;
                MessageBox.Show("Please Enter Company Name First");
                lblcompanynameerror.Visible = true;

            }
            else
            {
                btnok.Visible = true;
                lblcompanynameerror.Visible = false;
            }
        }

        private void txtcompanyname_Leave(object sender, EventArgs e)
        {
           // txtcompanyname_Validated(sender, e);
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet8.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.fintek_posDataSet8.Vendor);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendorTableAdapter.FillBy(this.fintek_posDataSet8.Vendor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } 

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "Search")
            {
                txtsearch.Text = "";
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
                SqlConnection sc = new SqlConnection(@connectionString);
                String query = "Select Vendor_name, Vendor_contact_person, Vendor_mobile_work, Vendor_mobile_main, Vendor_email, Vendor_address, Vendor_ntn, Vendor_strn  from Vendor where Vendor_name like @name + '%' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, sc);
                sda.SelectCommand.Parameters.AddWithValue("@name", txtsearch.Text.Trim());
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                // SqlDataReader reader;
                // reader = conn.ExecuteReader();
                // while (reader.Read())
                // {

                // }
            }
            catch
            {
                MessageBox.Show("Error in Searching");
            }
            finally
            {

            }
        }

        private void lblcompanynameerror_Click(object sender, EventArgs e)
        {

        }
    }
}
