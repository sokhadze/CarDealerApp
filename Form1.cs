﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerApp
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void MenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addNewCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewCarTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarType ct = new AddCarType();
            ct.Show();
        }
    }
}
