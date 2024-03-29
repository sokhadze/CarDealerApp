﻿using System;
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
        public static List<UserListClass> GetUserList()
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand sqlComm = conn.CreateCommand();
                    sqlComm.CommandText = "SELECT * FROM [CarDealerDB].[dbo].[Users]";
                    conn.Open();

                    SqlDataReader dr = sqlComm.ExecuteReader();
                    dt.Load(dr);
                }

                List<UserListClass> ls = (from c in dt.AsEnumerable()
                                             select new UserListClass
                                             {
                                                 ID = c.Field<int>("User_ID"),
                                                 FirstName = c.Field<string>("FirstName"),
                                                 LastName = c.Field<string>("LastName"),
                                                 Phone = c.Field<string>("Phone")
                                             }).ToList();

                return ls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<UserListClass>();
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
        public static List<CarModelListClass2> GetCarModelListMa(int ma_id)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand sqlComm = conn.CreateCommand();
                    sqlComm.CommandText = "SELECT M_ID, ModelName, ManName, MA_ID FROM [CarDealerDB].[dbo].[Model] INNER JOIN CarDealerDB.dbo.Manufacturer c ON c.MA_ID = Model.Manufacturer_ID where MA_ID = "+ma_id+"  ";
                    conn.Open();

                    SqlDataReader dr = sqlComm.ExecuteReader();
                    dt.Load(dr);
                }

                List<CarModelListClass2> ls = (from c in dt.AsEnumerable()
                                              select new CarModelListClass2
                                              {
                                                  M_ID = c.Field<int>("M_ID"),
                                                  ModelName = c.Field<string>("ModelName"),
                                                  ManName = c.Field<string>("ManName"),
                                                  MA_ID = c.Field<int>("MA_ID")
                                              }).ToList();

                return ls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<CarModelListClass2>();
            }
        }

        public static void CarList(DataGridView grid)
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
        public static void OrderList(DataGridView grid)
        {
            try
            {
                DataTable table = new DataTable();
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    using (var command = new SqlCommand("SELECT * FROM OrderList", conn))
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
        public static void UserList(DataGridView grid)
        {
            try
            {
                DataTable table = new DataTable();
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    using (var command = new SqlCommand("SELECT * FROM Users", conn))
                    {
                        table.Load(command.ExecuteReader());
                        grid.DataSource = table;
                        grid.Columns[0].Width = 22;
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void gayidulimanqanebi(DataGridView grid)
        {
            try
            {
                DataTable table = new DataTable();
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    using (var command = new SqlCommand("SELECT * FROM gayidulimanqanebi", conn))
                    {
                        table.Load(command.ExecuteReader());
                        grid.DataSource = table;
                        grid.Columns[0].Width = 22;
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
                        MessageBox.Show("მანქანის მოდელი წარმატებით წაიშალა");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteUser(int ID)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Creates a SQL command
                    using (var command = new SqlCommand("DELETE FROM dbo.Users WHERE User_ID = " + ID + "", conn))
                    {
                        command.ExecuteReader();
                        MessageBox.Show("მომხმარებელი წარმატებით წაიშალა");
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
        public static void UpdateCarModel(int ID, string _ModelName)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Creates a SQL command
                    using (SqlCommand sqlComm = new SqlCommand("UPDATE Model SET ModelName = @ModelName WHERE M_ID = @ID", conn))
                    {
                        sqlComm.Parameters.AddWithValue("@ModelName", _ModelName);
                        sqlComm.Parameters.AddWithValue("@ID", ID);
                        sqlComm.ExecuteNonQuery();
                        MessageBox.Show("მანქანის მოდელი წარმატებით განახლდა!");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UpdateUser(int ID, string _FirstName, string _LastName, string _Phone)
        {
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Creates a SQL command
                    using (SqlCommand sqlComm = new SqlCommand("UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone WHERE User_ID = @ID", conn))
                    {
                        sqlComm.Parameters.AddWithValue("@FirstName", _FirstName);
                        sqlComm.Parameters.AddWithValue("@LastName", _LastName);
                        sqlComm.Parameters.AddWithValue("@Phone", _Phone);
                        sqlComm.Parameters.AddWithValue("@ID", ID);
                        sqlComm.ExecuteNonQuery();
                        MessageBox.Show("მომხმარებელი წარმატებით განახლდა!");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void AddNewCarModel(int _ManufID, string model)
        {
            try
            {

                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "INSERT INTO Model(ModelName, Manufacturer_ID) VALUES(@ModelName,'" + _ManufID + "')";
                SqlCommand SqlComm = new SqlCommand(query, conn);
                // SqlComm.Parameters.Add(new SqlParameter("CarTypeImg", img));
                SqlComm.Parameters.AddWithValue("@ModelName", model);

                int x = SqlComm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " მანქანის მოდელი წარმატებით დაემატა!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddNewCar(int _ManufID, int _ModelID, int _TypeID, int _Condition, String _RYear, float _OdoMeter, float _Engine, float _Price)
        {
            try
            {

                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "INSERT INTO Car(Manufacturer_ID,Model_ID,CarType_ID,Price,Condition,Year,OdoMeter,Engine)" +
                    " VALUES("+_ManufID+","+_ModelID+","+_TypeID+","+_Price+","+_Condition+",'"+_RYear+"',"+_OdoMeter+","+_Engine+")";
                SqlCommand SqlComm = new SqlCommand(query, conn);
               

                int x = SqlComm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " ახალი მანქანა წარმატებით დაემატა!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddNewUser(string _fName, string _lName, string _Phone)
        {
            try
            {

                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "INSERT INTO Users(FirstName, LastName, Phone) VALUES(@fName,@lName,@Phone)";
                SqlCommand SqlComm = new SqlCommand(query, conn);
                SqlComm.Parameters.AddWithValue("@fName", _fName);
                SqlComm.Parameters.AddWithValue("@lName", _lName);
                SqlComm.Parameters.AddWithValue("@Phone", _Phone);

                int x = SqlComm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " ახალი მომხამრებელი წარმატებით დაემატა!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddNewOrder(int _userID, int _carID, string dt)
        {
            try
            {

                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = "INSERT INTO Orders(Usr_ID, Car_ID, Sell_DT) VALUES(@userid,@carid,@dt)";
                string query2 = "UPDATE [dbo].[Car] "+
                                "SET [SC] = 1"+
                                "FROM dbo.Car AS R"+
                                "INNER JOIN dbo.Orders AS P"+
                                       "ON R."+_carID+" = P.Car_ID"+
                                "WHERE R." + _carID + " = p.Car_ID ";
                SqlCommand SqlComm = new SqlCommand(query, conn);
                SqlCommand SqlComm2 = new SqlCommand(query2, conn);
                SqlComm.Parameters.AddWithValue("@userid", _userID);
                SqlComm.Parameters.AddWithValue("@carid", _carID);
                SqlComm.Parameters.AddWithValue("@dt", dt);
                int x = SqlComm.ExecuteNonQuery();
                SqlComm2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " Order წარმატებით დაემატა!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
