using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string PaymentMode { get; set; }

        private void CarList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealerDBDataSet.CarType' table. You can move, or remove it, as needed.
            
            DataClasses1DataContext db = new DataClasses1DataContext();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("მწარმოებელი");
            dt.Columns.Add("მოდელი");
            dt.Columns.Add("ტიპი");
            dt.Columns.Add("Kusu");
            dt.Columns.Add("Cena");
            DataRow row = null;


            var query = from car in db.Cars
                        join c in db.Manufacturers on car.Manufacturer_ID equals c.ID
                        join d in db.Models on car.Model_ID equals d.ID
                        join t in db.CarTypes on car.CarType_ID equals t.ID
                        select new
                        {
                            car.ID,
                            c.ManName,
                            d.ModelName,
                            t.CarTypeName,
                            t.CarTypeImg
                        };

            foreach (var x in query)
            {
                row = dt.NewRow();
               // byte[] img = (byte[])x.CarTypeImg;
                //dt.Rows.Add(x.ID, x.ManName, x.ModelName, x.CarTypeName, br);
                Console.WriteLine(x.CarTypeImg+" -----------");
            }
            dataGridView1.DataSource = query;

            //var query = from car in db.Cars
            //            join c in db.Manufacturers
            //            on car.Manufacturer_ID equals c.ID
            //            select new
            //            {
            //                car.Manufacturer_ID,
            //                Name = car.Manufacturer,
            //                c.ManName
            //            };

            //foreach (var x in query)
            //{
            //    row = dt.NewRow();
            //    dt.Rows.Add(x.ID, x.ManName);
            //}
            //dataGridView1.DataSource = query;

            //// Create the query 
            //var query = from c in cars.Cars
            //            select c;

            //// Execute the query 
            //foreach (var c in query)
            //{
            //    Console.WriteLine(c.CarType_ID);
            //} //Pause the application 

        }

        public Image ByteArrayToImage(byte[] Byte)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(Byte))
                {
                    Image returnImage = Image.FromStream(ms);
                    return returnImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
