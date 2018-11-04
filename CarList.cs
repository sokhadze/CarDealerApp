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
        public static Image ByteArrayToImage(byte[] bArray)
        {
            if (bArray == null)
                return null;

            Image newImage;

            try
            {
                using (MemoryStream ms = new MemoryStream(bArray, 0, bArray.Length))
                {
                    ms.Write(bArray, 0, bArray.Length);
                    newImage = Image.FromStream(ms, true);
                }
            }
            catch (Exception ex)
            {
                newImage = null;

                //Log an error here
            }

            return newImage;
        }
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
                            car.Year,
                            car.OdoMeter,
                            car.Condition,
                            car.Price,
                            car.Engine
                        };

         

            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].Width = 28;
            //dataGridView1.Columns[]
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




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
