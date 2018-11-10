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
            List<CarManufClass> manuf = MyMethods.GetCarManufList();
            foreach (var item in manuf)
            {
                ComboBoxItem it = new ComboBoxItem();
                it.Text = item.ManufcaturerName;
                it.Value = item.MA_ID;

                comboBox.Items.Add(it);

                comboBox.SelectedIndex = 0;
            }
            

           // MessageBox.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = (comboBox.SelectedItem as ComboBoxItem).Value.ToString();
        }
    }
}
