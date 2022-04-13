using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fintek_Solutions
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }
        int flag = 0;
        void clear_feilds()
        {
            txtitemcode.Text = "";
            txtitemname.Text = "";
            txtqty.Text = "";
            txtitemprice.Text = "";
            txtdescription.Text = "";
           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet21.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter2.Fill(this.fintek_posDataSet21.Item);
            // TODO: This line of code loads data into the 'category_name.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter2.Fill(this.category_name.Category);
            // TODO: This line of code loads data into the 'fintek_posDataSet10.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.fintek_posDataSet10.Item);
            // TODO: This line of code loads data into the 'fintek_posDataSet10.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.fintek_posDataSet10.Category);
            // TODO: This line of code loads data into the 'fintek_posDataSet2.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.fintek_posDataSet2.Item);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter.FillBy(this.fintek_posDataSet7.Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnsaveandnew_Click(object sender, EventArgs e)
        {
           try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
                SqlConnection sc = new SqlConnection(@connectionString);
            int category_id = 0; 
            SqlCommand id = new SqlCommand("Select * from Category where Category_name = @name", sc);
            id.Parameters.AddWithValue("name", ddcategory.Text);
            SqlDataReader reader1;
                sc.Open();
                reader1 = id.ExecuteReader();
            try
            {
                    
                if (reader1.Read())
                {
                    category_id = Convert.ToInt32(reader1["Category_id"]);
                }
                else
                {
                        MessageBox.Show("Please Select Valid Category");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                    sc.Close();
            }
            
           
                SqlCommand sm = new SqlCommand("insert into Item(Item_code, Item_name, Item_quantity, Item_price, Item_description, Category_id)  values('" + txtitemcode.Text + "','" + txtitemname.Text + "','" + txtqty.Text + "','" + txtitemprice.Text + "','" + txtdescription.Text + "','" + category_id + "' )", sc);
             
                if (flag == 0)
                {
                    sc.Open();
                    sm.ExecuteNonQuery();
                    
                    MessageBox.Show("Data saved Successfully");
                    
                    sc.Close();
                  
                }
                else
                {
                    MessageBox.Show("Data did not save Please Enter Desire Information");
                    sc.Close();
                }
                int item_vendor_id = 3;
                SqlCommand sm1 = new SqlCommand("insert into Inventory(Item_code, Item_name,Unit_price,Item_vendor) values('" + txtitemcode.Text + "','" + txtitemname.Text + "','" + txtitemprice.Text + "','" + item_vendor_id + "')", sc);
                sc.Open();
                sm1.ExecuteNonQuery();
                MessageBox.Show("Inventory Updated");
                clear_feilds();
                sc.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtitemprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ddcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.categoryTableAdapter1.FillBy(this.fintek_posDataSet9.Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter2.FillBy(this.category_name.Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtitemname_TextChanged(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            try
            {
                
                SqlCommand cmd = new SqlCommand("select * from Item where Item_name=@name", sc);
                cmd.Parameters.AddWithValue("name", txtitemname.Text.Trim());
                sc.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    MessageBox.Show("Duplicate Item Name Can not be inserted Please Try a Different Name");
                    sdr.Close();
                    sc.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter2.FillBy1(this.category_name.Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ddcategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ddcategory_Enter(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            try
            {

                string query = "select * from Category";
                SqlDataAdapter da = new SqlDataAdapter(query, sc);
                sc.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Category_name");
                ddcategory.DisplayMember = "Category_name";
                ddcategory.ValueMember = "Category_id";
                ddcategory.DataSource = ds.Tables["Category_name"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter2.FillBy(this.fintek_posDataSet21.Item);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
