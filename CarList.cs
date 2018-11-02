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
    public partial class CarList : Form
    {
        public CarList()
        {
            InitializeComponent();
        }

        private void CarList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealerDBDataSet.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this.carDealerDBDataSet.Car);

            //Get only short words
            var result = from car in this.carDealerDBDataSet.Car
                         select car;
            //Print each word out
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
