using System;
using System.Collections.Generic;
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
    }
}
