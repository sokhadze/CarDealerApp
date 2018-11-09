using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerApp
{
    public partial class AddCarManufacturer : Form
    {
        public AddCarManufacturer()
        {
            InitializeComponent();
        }

        private void AddCarManufacturer_Load(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "C:\\Users\\User\\source\\repos\\CarDealerApp\\CarDealerApp\\CarTypes\\sedan.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxManName.Text != "")
                {
                    string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                    SqlConnection conn = new SqlConnection(ConnString);

                    string query = "INSERT INTO Manufacturer(ManName) VALUES(@ManName)";
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand SqlComm = new SqlCommand(query, conn);
                    SqlComm.Parameters.AddWithValue("@ManName", TextBoxManName.Text);
                    int x = SqlComm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(x.ToString() + " მანქანის მწარმოებელი წარმატებით დაემატა!");
                    Close();
                }
                else
                {
                    MessageBox.Show("გთხოვთ შეავსოთ ცარიელი ველი!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
