using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CarDealerApp
{
    public partial class AddCarType : Form
    {
        public string SelectedImg = "";
        public AddCarType()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|ALL Files (*.*)|*.*";
                fd.Title = "Select Car Type Image";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    SelectedImg = fd.FileName.ToString();
                    pictureBox1.ImageLocation = SelectedImg;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string ConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnString);
                
                FileStream fs = new FileStream(SelectedImg,FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                //byte[] image = File.ReadAllBytes((int)fs.Length);
                byte[] img = new byte[fs.Length];
                fs.Read(img, 0, Convert.ToInt32(fs.Length));
                string query = "INSERT INTO CarType(CarTypeName,CarTypeImg) VALUES(N'"+TypeName.Text+ "','@img')";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand SqlComm = new SqlCommand(query, conn);
            
                // SqlComm.Parameters.Add(new SqlParameter("CarTypeImg", img));
                SqlComm.Parameters.Add("@img", SqlDbType.Image).Value = img;

                int x = SqlComm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString()+" მანქანის ტიპი წარმატებით დაემატა!");
                Close();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddCarType_Load(object sender, EventArgs e)
        {

        }
    }
}
