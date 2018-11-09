using System;
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
    public partial class CarManufacturerEdit : Form
    {
        public CarManufacturerEdit(int ID)
        {
            InitializeComponent();
            TextBoxID.Text = ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDD = 
            MyMethods.UpdateCarManufacturer(TextBoxID.Text)
        }
    }
}
