using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fintek_Solutions
{
    public partial class stockusercontrol : UserControl
    {
        public stockusercontrol()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnvendor_Click(object sender, EventArgs e)
        {
            Vendor vendor = new Vendor();
            vendor.Show();
        }

        private void btnsaleclient_Click(object sender, EventArgs e)
        {
            Sale_Client sc = new Sale_Client();
            sc.Show();
            
        }

        private void btnpurchaseinvoice_Click(object sender, EventArgs e)
        {
            Purchase_Invoice pi = new Purchase_Invoice();
            pi.Show();
        }

        private void btnsalebill_Click(object sender, EventArgs e)
        {
            Sale_bill sb = new Sale_bill();
            sb.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item_group ig = new Item_group();
            ig.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item it = new Item();
            it.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report rr = new report();
            rr.Show();
        }
    }
}
