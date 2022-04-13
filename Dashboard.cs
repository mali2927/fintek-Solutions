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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            stockusercontrol suc = new stockusercontrol();
            suc.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
