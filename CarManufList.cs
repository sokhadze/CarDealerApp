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
    public partial class CarManufList : Form
    {
        public CarManufList()
        {
            InitializeComponent();
        }
        public int RowID;

        private void CarManufList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyMethods.GetCarManufList();
            dataGridView1.Columns[0].Width = 28;
            dataGridView1.Columns[1].Width = 220;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyMethods.GetCarManufList();
            dataGridView1.Columns[0].Width = 28;
            dataGridView1.Columns[1].Width = 220;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                Int32.TryParse(selectedRow.Cells[0].Value.ToString(), out RowID);
                label1.Text = RowID.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RowID < 1)
                {
                    MessageBox.Show("გთხოვთ აირჩიოთ მანქანის მწარმოებელი!");
                }
                else
                {
                    MyMethods.DeleteCarManufacturer(RowID);
                    dataGridView1.DataSource = MyMethods.GetCarManufList();
                    dataGridView1.Columns[0].Width = 28;
                    dataGridView1.Columns[1].Width = 220;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RowID < 1)
                {
                    MessageBox.Show("გთხოვთ აირჩიოთ მანქანის მწარმოებელი!");
                }
                else
                {
                    CarManufacturerEdit cme = new CarManufacturerEdit();
                    cme.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
