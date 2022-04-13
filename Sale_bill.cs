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
    public partial class Sale_bill : Form
    {
        public Sale_bill()
        {
            InitializeComponent();
            
        }
        int flag = 100;
        void clear()
        {
            txtitem.Text = "";
            txtdescription.Text = "";
            txtqty.Text = "";
            txtrate.Text = "";
            txtamount.Text = "";
            txtgst.Text = "";
            txtgstamount.Text = "";
            txttotal.Text = "";
        }
        void generate_refernece_number()
        {
            txtinvoiceno.Text = "0";
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Invoice_No from Sale_bill order by Invoice_No desc ", sc);

                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtinvoiceno.Text = (int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                }
                else
                {
                    txtinvoiceno.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnsaveandconti_Click(object sender, EventArgs e)
        {
            count++;
            DataTable ss = new DataTable();
            ss.Columns.Add("ITEM");
            ss.Columns.Add("DESCRIPTION");
            ss.Columns.Add("QTY");
            ss.Columns.Add("RATE");
            ss.Columns.Add("AMOUNT");
            ss.Columns.Add("GST");
            ss.Columns.Add("GST Amount");
            ss.Columns.Add("Total");


            DataRow row = ss.NewRow();
            row["ITEM"] = txtitem.Text;
            row["DESCRIPTION"] = txtdescription.Text; 
            row["QTY"] = txtqty.Text;
            row["RATE"] = txtrate.Text;
            row["AMOUNT"] = txtamount.Text;
            row["GST"] = txtgst.Text;
            row["GST Amount"] = txtgstamount.Text;
            row["Total"] = txttotal.Text;
            ss.Rows.Add(row);
            if (txtitem.Text == "" || txtqty.Text == "" || txtrate.Text == "" || txtamount.Text == "" || txtgst.Text == "" || txtgstamount.Text == "" || txttotal.Text == "")
            {
                MessageBox.Show("Pleas Enter Desire Feilds First");
            }
            else
            {
                foreach (DataRow Drow in ss.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = Drow["ITEM"].ToString().Trim();
                    dataGridView1.Rows[num].Cells[1].Value = Drow["DESCRIPTION"].ToString().Trim();
                    dataGridView1.Rows[num].Cells[2].Value = Drow["QTY"].ToString().Trim();
                    dataGridView1.Rows[num].Cells[3].Value = float.Parse(Drow["RATE"].ToString());
                    dataGridView1.Rows[num].Cells[4].Value = float.Parse(Drow["AMOUNT"].ToString());
                    dataGridView1.Rows[num].Cells[5].Value = float.Parse(Drow["GST"].ToString());
                    dataGridView1.Rows[num].Cells[6].Value = float.Parse(Drow["GST Amount"].ToString());
                    dataGridView1.Rows[num].Cells[7].Value = float.Parse(Drow["Total"].ToString());
                }
                clear();
                string query;
                var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
                SqlConnection sc = new SqlConnection(@connectionString);


                if (count == 1)
                {
                    try
                    {
                        sc.Open();
                        SqlCommand cmd = new SqlCommand("Insert into Sale_bill (Invoice_No, Date)values('" + txtinvoiceno.Text + "','" + Convert.ToDateTime(txtdate.Text) + "')", sc);
                        int result = cmd.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("Error While Inserting Sale Bill");
                        }
                        else
                        {
                            MessageBox.Show("Saved Successfully Sale Bill");
                        }

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
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
                flag = 0;
            }
        }
        private void txtrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
                flag = 0;
            }
        }
        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
                flag = 0;
            }
        }

        private void txtgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((!char.IsDigit(ch) && ch != 8 && ch != 46) || Convert.ToInt32(txtgst.Text + e.KeyChar) >= 101 || txtgst.Text == "0" && ch != '\b')
            {
                e.Handled = true;
            }
        }
        int count = 0;

        private void btnsaveandexit_Click(object sender, EventArgs e)
        {
            string query, updatequery;
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            int Sale_id = 0;
            SqlCommand id_pur = new SqlCommand("Select Sale_bill_id from Sale_bill where Invoice_No = @name", sc);
            id_pur.Parameters.AddWithValue("name", txtinvoiceno.Text);
            SqlDataReader reader3;
            try
            {
                sc.Open();
                reader3 = id_pur.ExecuteReader();

                if (reader3.Read())
                {
                    Sale_id = Convert.ToInt32(reader3["Sale_bill_id"]);
                }
                else
                {
                    reader3.Close();
                    MessageBox.Show("Sale Bill id error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
            int inv_id = 0;
            SqlCommand inv = new SqlCommand("Select Inventory_id from Inventory where Item_Name = @name ",sc);
            inv.Parameters.AddWithValue("@name", txtitem.Text);
          
            try
            {
                sc.Open();
                SqlDataReader reader = inv.ExecuteReader();
                if (reader.Read())
                {
                    inv_id = Convert.ToInt32(reader["Sale_bill_id"]);
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Sale Bill id error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
            try
            {

                int[] Item_id = new int[dataGridView1.Rows.Count];
                string[] Item_name = new string[dataGridView1.Rows.Count];
                for (int i = 0; i < Item_id.Length; i++)
                {
                    Item_id[i] = 0;
                    Item_name[i] = " ";
                }

                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    try
                    {

                       Item_name[i] = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                        SqlCommand id = new SqlCommand("Select * from Item where Item_name = '" + Item_name[i] + "'", sc);
                        SqlDataReader reader1;
                        sc.Open();
                        reader1 = id.ExecuteReader();




                        if (reader1.Read())
                        {
                            Item_id[i] = Convert.ToInt32(reader1["Item_id"]);
                            query = @"insert into item_sale_bill (Item_id,Sale_bill_id,Quantity,cost,amount,gst,gst_amount,total,Item_name,inventory_id)values('" + Item_id[i] + "','" + Sale_id + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + Item_name[i] + "','" +5+ "')   ";
                            updatequery = @"Update Inventory Set Quantity -= '" + dataGridView1.Rows[i].Cells[2].Value + "' Where Item_name = '" + Item_name[i] + "'  ";

                            SqlCommand id1 = new SqlCommand(query, sc);
                            SqlCommand idup = new SqlCommand(updatequery, sc);
                            int result = id1.ExecuteNonQuery();
                            int result2 = idup.ExecuteNonQuery();
                            if (result < 0)
                            {
                                MessageBox.Show("Error While Inserting");
                            }
                            if (result2 < 0)
                            {
                                MessageBox.Show("Error While Updating Inventory");
                            }
                            else
                            {
                                MessageBox.Show("Saved Successfully");
                            }
                        }
                        else
                        {
                            reader1.Close();
                            MessageBox.Show("Please Select Valid Item");
                        }
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void Sale_bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet16.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.fintek_posDataSet16.Item);
            generate_refernece_number();
        }

        private void txtrate_Leave(object sender, EventArgs e)
        {
            try
            {
                float amount = 0;
                float qty = Convert.ToInt32(txtqty.Text);
                float rate = Convert.ToInt32(txtrate.Text);
                amount = qty * rate;
                txtamount.Text = amount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgst_Leave(object sender, EventArgs e)
        {
            try
            {

                float gstamount = 0;
                float amount = Convert.ToInt32(txtamount.Text);
                float gst = Convert.ToInt32(txtgst.Text);
                gst /= 100;
                gstamount = amount * gst;
                txtgstamount.Text = gstamount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgstamount_Leave(object sender, EventArgs e)
        {
            try
            {
                float total = 0;
                float gstamount = Convert.ToInt32(txtgstamount.Text);
                float amount = Convert.ToInt32(txtamount.Text);
                total = amount + gstamount;
                txttotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtitem_Enter(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            try
            {

                string query = "select Item_id,Item_name from Item";
                SqlDataAdapter da = new SqlDataAdapter(query, sc);
                sc.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Item_name");
                txtitem.DisplayMember = "Item_name";
                txtitem.ValueMember = "Item_id";
                txtitem.DataSource = ds.Tables["Item_name"];
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
    }
}
