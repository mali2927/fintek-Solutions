﻿using System;
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
    public partial class users : Form
    {
        public users()
        {
            
            InitializeComponent();
            userControl11.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
        }
    }
}
