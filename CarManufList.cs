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
    public partial class CarManufList : Form
    {
        public CarManufList()
        {
            InitializeComponent();
        }

        private void CarManufList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyMethods.GetCarManufList();
            dataGridView1.Columns[0].Width = 28;
            dataGridView1.Columns[1].Width = 220;
        }
    }
}
