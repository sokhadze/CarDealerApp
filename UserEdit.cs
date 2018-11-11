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

        }
    }
}
