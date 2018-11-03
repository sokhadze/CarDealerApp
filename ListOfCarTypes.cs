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
            string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    new SqlCommand("SELECT * FROM CarType", conn));
                DataSet dataSet = new DataSet();
                DataGridView dg = new DataGridView();
                dataAdapter.Fill(dataSet1);
                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["pic"]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(mem);
                }
            }
            
        }

        private void carTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDealerDBDataSet1);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.carTypeTableAdapter.FillBy(this.carDealerDBDataSet1.CarType);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
