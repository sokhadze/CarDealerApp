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
        int manuf_id;
        int model_id;
        int type_id;
        int condition;
        private void AddNewCar_Load(object sender, EventArgs e)
        {
            //date format
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


            //car type combo box
            List<CarTypeListClass> type = MyMethods.GetCarTypeList();
            foreach (var item in type)
            {
                ComboBoxItem it2 = new ComboBoxItem();
                it2.Text = item.CarTypeName;
                it2.Value = item.T_ID;

                comboBoxCarType.Items.Add(it2);
                comboBoxCarType.SelectedIndex = 0;
            }

            //condition combo box
            ComboBoxItem it3 = new ComboBoxItem();
            ComboBoxItem it4 = new ComboBoxItem();
            it3.Text = "New";
            it3.Value = 1;
            it4.Text = "Used";
            it4.Value = 0;
            comboBoxCondition.Items.Add(it3);
            comboBoxCondition.Items.Add(it4);
            comboBoxCondition.SelectedIndex = 0;
            
        }



        private void AddNewCarBtn_Click(object sender, EventArgs e)
        {
            Int32.TryParse((comboBoxCarManuf.SelectedItem as ComboBoxItem).Value.ToString(), out manuf_id);

            Console.WriteLine(comboBoxCarManuf.Text +"|"+ comboBoxCarModel.Text + "|" + comboBoxCarType.Text + "|" + comboBoxCondition.Text);
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

        private void comboBoxCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int man_id;
            Int32.TryParse(comboBoxCarManuf.Text, out man_id);

            List<CarModelListClass2> model = MyMethods.GetCarModelListMa(manuf_id);
            foreach (var item in model)
            {
                ComboBoxItem it2 = new ComboBoxItem();
                it2.Text = item.ModelName;
                it2.Value = item.M_ID;

                comboBoxCarModel.Items.Add(it2);
                comboBoxCarModel.SelectedIndex = 0;
            }
        }

        private void comboBoxCarModel_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void comboBoxCarManuf_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxCarManuf_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBoxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
