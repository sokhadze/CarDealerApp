using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerApp
{
    public partial class CarList : Form
    {
        public CarList()
        {
            InitializeComponent();
        }
        public int RowID;

        private void CarList_Load(object sender, EventArgs e)
        {
            MyMethods.CarList(dataGridView1);

            //dataGridView1.DataSource = MyMethods.GetCarList();
            dataGridView1.Columns[0].Width = 24;
            dataGridView1.ReadOnly = true;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //label1.Text = "";
            //label1.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            MyMethods.CarList(dataGridView1);
            dataGridView1.Columns[0].Width = 24;
            dataGridView1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyMethods.DeleteCar(RowID);
            MyMethods.CarList(dataGridView1);
            dataGridView1.Columns[0].Width = 24;
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (RowID.Equals(""))
                {
                    MessageBox.Show("გთხოვთ აირჩიოთ მანქანა!");
                }
                else
                {
                    CarEdit ce = new CarEdit(RowID);
                    ce.Show();
                    int idd;
                    Int32.TryParse(label1.Text.ToString(), out idd);
                    //ce. = idd;
                }
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
    }
}
