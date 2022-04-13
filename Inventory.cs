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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fintek_posDataSet15.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter1.Fill(this.fintek_posDataSet15.Inventory);
            // TODO: This line of code loads data into the 'fintek_posDataSet14.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.fintek_posDataSet14.Inventory);

        }
    }
}
