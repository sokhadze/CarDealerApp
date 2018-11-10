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
    public partial class CarModelEdit : Form
    {
        public CarModelEdit(int id)
        {
            InitializeComponent();
            RowID = id;
        }
        int RowID;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxModelName.Text != "")
                {
                    MyMethods.UpdateCarModel(RowID, textBoxModelName.Text);
                }
                else
                {
                    MessageBox.Show("გთხოვთ შეავსოთ ცარიელი ველები!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarModelEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = RowID.ToString();
        }
    }
}
