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
    public partial class ListOfCarTypes : Form
    {
        public ListOfCarTypes()
        {
            InitializeComponent();
        }

        

        private void ListOfCarTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealerDBDataSet1.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.carDealerDBDataSet1.CarType);
            //DataClasses1DataContext db = new DataClasses1DataContext();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("მწარმოებელი");
            //dt.Columns.Add("მოდელი");
            //DataRow row = null;


            //var query = from car in db.CarTypes

            //            select car;

            //foreach (var x in query)
            //{
            //    row = dt.NewRow();
            //    //byte[] img = Convert.ToByte(x.CarTypeImg);
            //    //string base64String = Convert.ToBase64String(x.CarTypeImg, 0, x.CarTypeImg.Length);

            //    //MemoryStream ms = new MemoryStream(img);
            //    dt.Rows.Add(x.ID, x.CarTypeName, x.CarTypeName, MyMethods.ConvertToImage(x.CarTypeImg.ToArray()));
            //    //Console.WriteLine(Convert.ToBase64String(ConvertToImage(x.CarTypeImg))" -----------");
            //}
            //dataGridView1.DataSource = query;
            
            
        }

        private void carTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDealerDBDataSet1);

        }

        
    }
}
