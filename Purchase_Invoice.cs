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
    public partial class Purchase_Invoice : Form
    {
        public Purchase_Invoice()
        {
            InitializeComponent();
        }
        void clear_feilds()
        {
            txtitem.Text = "";
            txtdescription.Text="";
            txtqty.Text = "";
            txtrate.Text = "";
            txtamount.Text = "";
            txtgst.Text = "";
            txtgstamount.Text = "";
            txttotal.Text = "";
        }
        private void Purchase_Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet13.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.fintek_posDataSet13.Item);
            // TODO: This line of code loads data into the 'fintek_posDataSet5.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.fintek_posDataSet5.Vendor);
            // TODO: This line of code loads data into the 'fintek_posDataSet1.Item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.fintek_posDataSet1.Item);
            generate_refernece_number();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int count = 0;
        int get_vendor_id()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            int Vendor_id = 0;
            SqlCommand id1 = new SqlCommand("Select Vendor_id from Vendor where Vendor_name = @name", sc);
            id1.Parameters.AddWithValue("name", txtvendor.Text);



            try
            {
                SqlDataReader reader2;
                sc.Open();
                reader2 = id1.ExecuteReader();
                if (reader2.Read())
                {
                    Vendor_id = Convert.ToInt32(reader2["Vendor_id"]);
                    return Vendor_id;
                }
                else
                {
                    reader2.Close();
                    MessageBox.Show("Please Select Valid Vendor");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {

                sc.Close();
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
                clear_feilds();
                string query;
                var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
                SqlConnection sc = new SqlConnection(@connectionString);
               
              

                if (count == 1)
                {
                    try
                    {
                        sc.Open();
                        SqlCommand cmd = new SqlCommand("Insert into Purchase_bill (Date_of_bill, Purchase_ref_no,Bill_due_date,Purchase_bill_description,Vendor_id)values('" + Convert.ToDateTime(txtdate.Text) + "','" + txtrefno.Text + "','" + Convert.ToDateTime(txtduedate.Text) + "','" + txtdescription.Text + "','" + get_vendor_id() + "')", sc);
                        int result = cmd.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("Error While Inserting Purchase Bill");
                        }
                        else
                        {
                            MessageBox.Show("Saved Successfully Purchase Bill");
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
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendorTableAdapter.FillBy(this.fintek_posDataSet5.Vendor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendorTableAdapter.FillBy1(this.fintek_posDataSet5.Vendor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
            }
        }

        private void txtrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtgstamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char ch = e.KeyChar;
                if ((!char.IsDigit(ch) && ch != 8 && ch != 46) || Convert.ToInt32(txtgst.Text + e.KeyChar) >= 101 || txtgst.Text == "0" && ch != '\b')
                {
                    e.Handled = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void generate_refernece_number()
        {
            txtrefno.Text = "0";
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Purchase_ref_no from Purchase_bill order by Purchase_ref_no desc ", sc);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if(ds.Tables[0].Rows.Count>0 )
                {
                    txtrefno.Text = (int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString().Trim();
                }
                else
                {
                    txtrefno.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int test = 0;
        private void btnsaveandexit_Click(object sender, EventArgs e)
        {
            string query, updatequery;
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            int purchase_id = 0;
            SqlCommand id_pur = new SqlCommand("Select Purchase_bill_id from Purchase_bill where Purchase_ref_no = @name", sc);
            id_pur.Parameters.AddWithValue("name", txtrefno.Text);
            SqlDataReader reader3;
            try
            {
                sc.Open();
                reader3 = id_pur.ExecuteReader();

                if (reader3.Read())
                {
                    purchase_id = Convert.ToInt32(reader3["Purchase_bill_id"]);
                }
                else
                {
                    reader3.Close();
                    MessageBox.Show("Purchase Bill id error");
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
               
                int[] Item_id = new int [dataGridView1.Rows.Count] ;
                string[] Item_name = new string[dataGridView1.Rows.Count];
                for(int i =0;i<Item_id.Length;i++)
                {
                    Item_id[i] = 0;
                    Item_name[i] = " ";
                }
               
                for (int i = 0;i<dataGridView1.Rows.Count-1;i++)
                {
                    try
                    {
                        try
                        {
                            test++;
                            Item_name[i] = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                            
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                       
                        SqlCommand id = new SqlCommand("Select * from Item where Item_name = '" + Item_name[i] + "'", sc);
                        SqlDataReader reader1;
                        sc.Open();
                        reader1 = id.ExecuteReader();

                        if (reader1.Read())
                        {
                            Item_id[i] = Convert.ToInt32(reader1["Item_id"]);
                            query = @"insert into item_vendor (Item_id,Purchase_bill_id,Vendor_id,Quantity,cost,amount,gst,gst_amount,total)values('" + Item_id[i] + "','" + purchase_id + "','" + get_vendor_id() + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "')   ";
                            
                            SqlCommand id1 = new SqlCommand(query,sc);
                          
                           
                            int result = id1.ExecuteNonQuery();
                        
                            if(result<0)
                            {
                                MessageBox.Show("Error While Inserting");
                            }
                            else
                            {
                                MessageBox.Show("Saved Successfully");
                            }
                            if(test == dataGridView1.Rows.Count-1)
                            {
                                this.Close();
                            }
                            using (var updateCommand = new SqlCommand("update Inventory set Quantity += '" + dataGridView1.Rows[i].Cells[2].Value + "' where Item_Name ='" + Item_name[i] + "' ", sc))
                            {

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter1.FillBy(this.fintek_posDataSet13.Item);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
            }catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgstamount_Leave(object sender, EventArgs e)
        {
            float total = 0;
                int first = 0, second = 0;
            try 
            {
                float gstamount = Convert.ToInt32(txtgstamount.Text);
                float amount = Convert.ToInt32(txtamount.Text);
                total = amount + gstamount;
                if (Int32.TryParse(txtamount.Text, out second) && Int32.TryParse(txtgstamount.Text, out first))
                {
                    txttotal.Text = (first + second).ToString();
                }

                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtvendor_Enter(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            try
            {

                string query = "select Vendor_name,Vendor_id from Vendor";
                SqlDataAdapter da = new SqlDataAdapter(query, sc);
                sc.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Vendor_name");
                txtvendor.DisplayMember = "Vendor_name";
                txtvendor.ValueMember = "Vendor_id";
                txtvendor.DataSource = ds.Tables["Vendor_name"];
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