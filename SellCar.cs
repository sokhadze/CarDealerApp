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
    public partial class SellCar : Form
    {
        public SellCar(int rowid)
        {
            InitializeComponent();
            RowID = rowid;
        }
        int RowID;
        private void SellCar_Load(object sender, EventArgs e)
        {
            List<UserListClass> user = MyMethods.GetUserList();
            foreach (var item in user)
            {
                ComboBoxItem it = new ComboBoxItem();
                it.Text = item.FirstName+" "+item.LastName;
                it.Value = item.ID;

                comboBox1.Items.Add(it);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int usrid;
                Int32.TryParse((comboBox1.SelectedItem as ComboBoxItem).Value.ToString(), out usrid);
                string dt = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
                MyMethods.AddNewOrder(usrid, RowID,dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
