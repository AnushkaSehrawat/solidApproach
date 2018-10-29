using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class CarProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "car";
        }

        public void Book()
        {
            Console.WriteLine("Car Booked");
        }

        public void Save()
        {
            Console.WriteLine("Car Product saved");
        }
    }
}
