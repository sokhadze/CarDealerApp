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
        public int ID { get; set; }
        public string ManufcaturerName { get; set; }
    }

    public class CarTypeListClass
    {
        public int ID { get; set; }
        public string CarTypeName { get; set; }
        public byte[] CarTypeImg { get; set; }
    }
}
