using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fintek_Solutions
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
            lblpursum.Visible = false;
            lblsalestock.Visible = false;
            lblbalance.Visible = false;
            btnpdf.Visible = false;

        }
       

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet17.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.fintek_posDataSet17.Item);

        }

        private void txtsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int salesum = 0;
            int pur_sum1 = 0;
            lblpursum.Text = "";
            lblsalestock.Text = "";
            lblbalance.Text = "";
            var connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection sc = new SqlConnection(@connectionString);
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand("SELECT Purchase_bill.Date_of_bill AS Date, Purchase_bill.Purchase_total AS Details, Item_vendor.Quantity AS Stock FROM     Purchase_bill INNER JOIN  Item_vendor ON Purchase_bill.Purchase_bill_id = Item_vendor.Purchase_bill_id INNER JOIN   Item ON Item_vendor.Item_id = Item.Item_id Where item.Item_name = @name ORDER BY Date ", sc);
                var test = cmd.Parameters.AddWithValue("name", txtsearch.Text);
               
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table1 = new DataTable();
                    table1.Load(reader);
                    dataGridView1.DataSource = table1;
                

                SqlCommand purchase_sum = new SqlCommand("SELECT SUM(Item_vendor.Quantity) AS Purchase_Stock FROM     Item_vendor INNER JOIN  Item ON Item_vendor.Item_id = Item.Item_id   where Item.Item_name = @pursum ", sc);
                 var test2 = purchase_sum.Parameters.AddWithValue("pursum", txtsearch.Text);
              
                    pur_sum1 = Convert.ToInt32(purchase_sum.ExecuteScalar());
                    lblpursum.Text = pur_sum1.ToString();
                    lblpursum.Visible = true;   
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
                sc.Open();
   
                SqlCommand cmd1 = new SqlCommand("SELECT  Sale_bill.Date, Sale_bill.Sale_total AS Details, Item_sale_bill.Quantity AS Stock FROM     Sale_bill INNER JOIN Item_sale_bill ON Sale_bill.Sale_bill_id = Item_sale_bill.Sale_bill_id INNER JOIN   Item ON Item_sale_bill.Item_id = Item.Item_id  Where Item.Item_name = @name ORDER BY Sale_bill.Date ", sc);
                cmd1.Parameters.AddWithValue("name", txtsearch.Text);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader1);

                dataGridView2.DataSource = table;



                SqlCommand sale_sum = new SqlCommand("SELECT SUM(Item_sale_bill.Quantity) AS Expr1 FROM     Item_sale_bill INNER JOIN  Item ON Item_sale_bill.Item_id = Item.Item_id where Item.Item_name = @sale_sum_query ", sc);
                var test1 = sale_sum.Parameters.AddWithValue("sale_sum_query", txtsearch.Text);

                salesum = Convert.ToInt32(sale_sum.ExecuteScalar());
                lblsalestock.Text = salesum.ToString();
                lblsalestock.Visible = true;

                int balance = 0;


                if (salesum != 0 && pur_sum1 != 0)
                {
                    balance = pur_sum1 - salesum;
                    lblbalance.Text = balance.ToString();
                    lblbalance.Visible = true;
                }
                if (salesum == 0)
                {
                    balance = pur_sum1;
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








            //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //{
            //    pur_sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            //}
            //lblpursum.Text = pur_sum.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
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
                txtsearch.DisplayMember = "Item_name";
                txtsearch.ValueMember = "Item_id";
                txtsearch.DataSource = ds.Tables["Item_name"];
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

        private void txtsearch_Click(object sender, EventArgs e)
        {
           
        }

        private void txtsearch_DragEnter(object sender, DragEventArgs e)
        {
           
        }
    }
}
