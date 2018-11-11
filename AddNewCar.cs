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
    public partial class AddNewCar : Form
    {
        public AddNewCar()
        {
            InitializeComponent();
        }

        private void AddNewCar_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format= DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            //manufacturer combo box
            List<CarManufClass> manuf = MyMethods.GetCarManufList();
            foreach (var item in manuf)
            {
                ComboBoxItem it = new ComboBoxItem();
                it.Text = item.ManufcaturerName;
                it.Value = item.MA_ID;

                comboBoxCarManuf.Items.Add(it);
                comboBoxCarManuf.SelectedIndex = 0;
            }
            //model combo box
            List<CarModelListClass> model = MyMethods.GetCarModelList();
            foreach (var item in model)
            {
                ComboBoxItem it2 = new ComboBoxItem();
                it2.Text = item.ModelName;
                it2.Value = item.M_ID;

                comboBoxCarModel.Items.Add(it2);

                comboBoxCarModel.SelectedIndex = 0;
            }
        }

        private void AddNewCarBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBoxCarManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
