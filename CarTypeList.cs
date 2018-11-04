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
    public partial class CarTypeList : Form
    {
        public CarTypeList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CarTypeList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyMethods.GetCarTypeList();
            dataGridView1.Columns[0].Width = 24;
        }
    }
}
