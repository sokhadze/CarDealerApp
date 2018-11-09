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
            try
            {
                if (textBoxManName.Text != "")
                {
                    int IDD;
                    Int32.TryParse(TextBoxID.Text, out IDD);
                    MyMethods.UpdateCarManufacturer(IDD, textBoxManName.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show("გთხოვთ შეავსოთ ცარიელი ველი");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
