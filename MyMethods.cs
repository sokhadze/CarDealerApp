using System;
using System.Collections.Generic;
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
    class MyMethods
    {
        public static Image ConvertToImage(System.Data.Linq.Binary iBinary)
        {
            try
            {
                var arrayBinary = iBinary.ToArray();
                Image rImage = null;

                using (MemoryStream ms = new MemoryStream(arrayBinary))
                {
                    rImage = Image.FromStream(ms);
                }
                return rImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static List<CarManufClass> GetCarManufList()
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand sqlComm = conn.CreateCommand();
                    sqlComm.CommandText = "SELECT * FROM [CarDealerDB].[dbo].[Manufacturer]";
                    conn.Open();

                    SqlDataReader dr = sqlComm.ExecuteReader();
                    dt.Load(dr);
                }

                List<CarManufClass> ls = (from c in dt.AsEnumerable()
                                 select new CarManufClass
                                 {
                                     ID = c.Field<int>("ID"),
                                     ManufcaturerName = c.Field<string>("ManName"),
                                 }).ToList();

                return ls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<CarManufClass>();
            }
        }

        public static List<CarTypeListClass> GetCarTypeList()
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand sqlComm = conn.CreateCommand();
                    sqlComm.CommandText = "SELECT * FROM [CarDealerDB].[dbo].[CarType]";
                    conn.Open();

                    SqlDataReader dr = sqlComm.ExecuteReader();
                    dt.Load(dr);
                }

                List<CarTypeListClass> ls = (from c in dt.AsEnumerable()
                                          select new CarTypeListClass
                                          {
                                              ID = c.Field<int>("ID"),
                                              CarTypeName = c.Field<string>("CarTypeName"),
                                              CarTypeImg = c.Field<byte[]>("CarTypeImg")
                                          }).ToList();

                return ls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<CarTypeListClass>();
            }
        }

        public static List<CarModelListClass> GetCarModelList()
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand sqlComm = conn.CreateCommand();
                    sqlComm.CommandText = "SELECT Model_ID, ModelName, ManName FROM [CarDealerDB].[dbo].[Model] INNER JOIN CarDealerDB.dbo.Manufacturer c ON c.ID = Model.Manufacturer_ID ";
                    conn.Open();

                    SqlDataReader dr = sqlComm.ExecuteReader();
                    dt.Load(dr);
                }

                List<CarModelListClass> ls = (from c in dt.AsEnumerable()
                                             select new CarModelListClass
                                             {
                                                 Model_ID = c.Field<int>("Model_ID"),
                                                 ModelName = c.Field<string>("ModelName"),
                                                 ManName = c.Field<string>("ManName")
                                             }).ToList();

                return ls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<CarModelListClass>();
            }
        }
    }
}
