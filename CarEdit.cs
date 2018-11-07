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
    public partial class CarEdit : Form
    {
        public CarEdit(int rowid)
        {
            InitializeComponent();
            Getid = rowid;
        }

        public int Getid { get; set; }

        private void CarEdit_Load(object sender, EventArgs e)
        {
            textBoxID.Text = Getid.ToString();
        }
    }
}
