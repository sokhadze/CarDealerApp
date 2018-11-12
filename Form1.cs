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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void MenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addNewCarTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewCarTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarType ct = new AddCarType();
            ct.Show();
        }

        private void CarList_Click(object sender, EventArgs e)
        {
            CarList cl = new CarList();
            cl.Show();
        }

        private void carTypesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarTypeList lct = new CarTypeList();
            lct.Show();
        }

        private void carManufacturerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarManufList cml = new CarManufList();
            cml.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
          
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carModelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarModelList cml = new CarModelList();
            cml.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CarModelList cml = new CarModelList();
            cml.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarManufList cml = new CarManufList();
            cml.Show();
        }

        private void addNewCarManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarManufacturer acm = new AddCarManufacturer();
            acm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserList ul = new UserList();
            ul.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCar nc = new AddNewCar();
            nc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewCar nc = new AddNewCar();
            nc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderList ol = new OrderList();
            ol.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
