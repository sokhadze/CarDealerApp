using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerApp
{
    class MyClass
    {


    }

    public class CarManufClass
    {
        public int MA_ID { get; set; }
        public string ManufcaturerName { get; set; }
    }

    public class CarTypeListClass
    {
        public int T_ID { get; set; }
        public string CarTypeName { get; set; }
        public byte[] CarTypeImg { get; set; }
    }

    public class CarModelListClass
    {
        public int M_ID { get; set; }
        public string ModelName { get; set; }
        public string ManName { get; set; }
    }

    public class UserListClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }

    public class CarModelListClass2
    {
        public int M_ID { get; set; }
        public string ModelName { get; set; }
        public string ManName { get; set; }
        public int MA_ID { get; set; }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
