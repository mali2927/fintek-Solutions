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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtpass.PasswordChar=='*')
            {
                linkLabel2.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                linkLabel1.BringToFront();
                txtpass.PasswordChar = '*';
            }
        }
    }
}
