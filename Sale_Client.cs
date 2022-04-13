using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fintek_Solutions
{
    public partial class Sale_Client : Form
    {
        public Sale_Client()
        {
            InitializeComponent();
        }
        int flag = 100;

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
            }
        }

        private void txtmobilenowork_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
            }
        }

        private void txtntn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
            }
        }

        private void txtstrn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
            }
        }
    }
}
