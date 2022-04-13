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
    public partial class Item_group : Form
    {
        public Item_group()
        {
            InitializeComponent();
        }
        void Clear_feilds()
        {
            txtcategoryname.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          

            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
                SqlConnection sc = new SqlConnection(@connectionString);
                String query = "Select Category_name from Category where Category_name like @category + '%' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, sc);
                sda.SelectCommand.Parameters.AddWithValue("@category", txtsearch.Text.Trim()) ;
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);

            String name;
            SqlCommand cmd = new SqlCommand("select * from Category where Category_name=@name", sc);
            cmd.Parameters.AddWithValue("name", txtcategoryname.Text.Trim());
            sc.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                MessageBox.Show("Duplicate Item Group Can not be inserted Please Try a Different Name");
                sdr.Close();
                sc.Close();

            }
            else
            {
                sdr.Close();
                SqlCommand sm = new SqlCommand("insert into Category(Category_name)  values('" + txtcategoryname.Text + "' )", sc);
                sm.ExecuteNonQuery();
                MessageBox.Show("Item Group saved Successfully");
                sc.Close();
                Clear_feilds();
                this.Refresh();
            }
            sc.Close();

            //Sql select command for avoid duplications
   
        }

        private void Item_group_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet6.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.fintek_posDataSet6.Category);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter.FillBy(this.fintek_posDataSet6.Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear_feilds();
        }

        private void btnsaveandexit_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);

            String name;
            SqlCommand cmd = new SqlCommand("select * from Category where Category_name=@name", sc);
            cmd.Parameters.AddWithValue("name", txtcategoryname.Text.Trim());
            sc.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                MessageBox.Show("Duplicate Item Group Can not be inserted Please Try a Different Name");
                sdr.Close();
                sc.Close();
            }
            else
            {
                sdr.Close();
                SqlCommand sm = new SqlCommand("insert into Category(Category_name)  values('" + txtcategoryname.Text + "' )", sc);
                sm.ExecuteNonQuery();
                MessageBox.Show("Item Group saved Successfully");
                sc.Close();
                Clear_feilds();
                
                Dashboard db = new Dashboard();
                db.Show();
                
            }
            sc.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
