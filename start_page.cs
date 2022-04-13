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
    public partial class start_page : Form
    {
        public start_page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            companyregistrer f1 = new companyregistrer();
                f1.Show();
            this.Visible = false;
        }
            
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            companyregistrer f1 = new companyregistrer();
            f1.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dd = new Dashboard();
            dd.Show();
            this.Visible = false;
        }
    }
}
