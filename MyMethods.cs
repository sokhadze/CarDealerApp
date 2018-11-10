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
                                     MA_ID = c.Field<int>("MA_ID"),
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
                                              T_ID = c.Field<int>("T_ID"),
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
                    sqlComm.CommandText = "SELECT M_ID, ModelName, ManName FROM [CarDealerDB].[dbo].[Model] INNER JOIN CarDealerDB.dbo.Manufacturer c ON c.MA_ID = Model.Manufacturer_ID ";
                    conn.Open();

                    SqlDataReader dr = sqlComm.ExecuteReader();
                    dt.Load(dr);
                }

                List<CarModelListClass> ls = (from c in dt.AsEnumerable()
                                             select new CarModelListClass
                                             {
                                                 M_ID = c.Field<int>("M_ID"),
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
        
        public static void CarList( DataGridView grid)
        {
            try
            {
                DataTable table = new DataTable();
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    using (var command = new SqlCommand("SELECT * FROM SelectCar", conn))
                    {
                        table.Load(command.ExecuteReader());
                        grid.DataSource = table;
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteCar(int ID)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Creates a SQL command
                    using (var command = new SqlCommand("DELETE FROM dbo.Car WHERE ID = "+ID+"", conn))
                    {
                        command.ExecuteReader();
                        MessageBox.Show("მანქნა წარმატებით წაიშალა");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteCarManufacturer(int ID)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Creates a SQL command
                    using (var command = new SqlCommand("DELETE FROM dbo.Manufacturer WHERE MA_ID = " + ID + "", conn))
                    {
                        command.ExecuteReader();
                        MessageBox.Show("მანქანის მწარმოებელი წარმატებით წაიშალა");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteCarModel(int ID)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Creates a SQL command
                    using (var command = new SqlCommand("DELETE FROM dbo.Model WHERE M_ID = " + ID + "", conn))
                    {
                        command.ExecuteReader();
                        MessageBox.Show("მანქანის მწარმოებელი წარმატებით წაიშალა");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UpdateCarManufacturer(int ID, string _ManName)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Creates a SQL command
                    using (SqlCommand sqlComm = new SqlCommand("UPDATE Manufacturer SET ManName = @ManName WHERE MA_ID = @ID", conn))
                    {
                        sqlComm.Parameters.AddWithValue("@ManName", _ManName);
                        sqlComm.Parameters.AddWithValue("@ID", ID);
                        sqlComm.ExecuteNonQuery();
                        MessageBox.Show("მანქანის მწარმოებელი წარმატებით განახლდა!");
                        
                    }

                    conn.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!");

                MessageBox.Show(ex.Message);
            }
        }

        public static void AddNewCar()
        {

        }
    }
}
