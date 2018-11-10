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
    public partial class AddCarModel : Form
    {
        public AddCarModel()
        {
            InitializeComponent();
        }

        private void AddCarModel_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Mahesh Chand");
            comboBox.Items.Add("Mike Gold");
            comboBox.Items.Add("Praveen Kumar");
            comboBox.Items.Add("Raj Beniwal");
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label3.Text = comboBox.Text;
        }
    }
}
