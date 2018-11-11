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
    public partial class UserEdit : Form
    {
        public UserEdit(int id, string fname, string lname, string phone)
        {
            InitializeComponent();
            RowID = id;
            FirstName = fname;
            LastName = lname;
            Phone = phone;
        }
        int RowID;
        string FirstName;
        string LastName;
        string Phone;

        private void UserEdit_Load(object sender, EventArgs e)
        {
            textBoxID.Text = ""+RowID;
            textBoxFName.Text = FirstName;
            textBoxLName.Text = LastName;
            textBoxPhone.Text = Phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPhone.Text == "" || textBoxLName.Text == "" || textBoxFName.Text == "")
                {
                    MessageBox.Show("გთხოვთ შეავსოთ ცარიელი ველები!");
                }
                else
                {
                    MyMethods.UpdateUser(RowID, textBoxFName.Text, textBoxLName.Text,textBoxPhone.Text);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
