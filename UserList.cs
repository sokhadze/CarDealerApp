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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }
        int RowID;
        string FirstName;
        string LastName;
        string Phone;

        private void UsersList_Load(object sender, EventArgs e)
        {
            MyMethods.UserList(dataGridView1);
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
                LabelID.Text = RowID.ToString();
                FirstName = selectedRow.Cells[1].Value.ToString();
                LastName = selectedRow.Cells[2].Value.ToString();
                Phone = selectedRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMethods.UserList(dataGridView1);
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            AddNewUser anu = new AddNewUser();
            anu.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RowID > 0)
                {                 
                    UserEdit ue = new UserEdit(RowID, FirstName, LastName, Phone);
                    ue.Show();
                    MyMethods.UserList(dataGridView1);
                    LabelID.Text = "0";
                }
                else
                {
                    MessageBox.Show("გთხოვთ აირჩიოთ მომხმარებელი");
                }
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
                if (RowID>0)
                {
                    MyMethods.DeleteUser(RowID);
                    MyMethods.UserList(dataGridView1);
                    LabelID.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
