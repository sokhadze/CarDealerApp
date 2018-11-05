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

        private void CarModelList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyMethods.GetCarModelList();
            dataGridView1.Columns[0].Width = 26;
        }
    }
}
