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
    public partial class CarModelList : Form
    {
        public CarModelList()
        {
            InitializeComponent();
        }
        int RowID;
        private void CarModelList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyMethods.GetCarModelList();
            dataGridView1.Columns[0].Width = 26;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                Int32.TryParse(selectedRow.Cells[0].Value.ToString(), out RowID);
                LabelID.Text = RowID.ToString();

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
                    MyMethods.DeleteCarModel(RowID);
                    dataGridView1.DataSource = MyMethods.GetCarModelList();
                    dataGridView1.Columns[0].Width = 26;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
