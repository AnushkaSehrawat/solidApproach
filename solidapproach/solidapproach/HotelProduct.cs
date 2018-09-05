using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class HotelProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Hotel";
        }

        public void Book()
        {
            Console.WriteLine("Hotel Booked");
        }

        public void Save()
        {
            Console.WriteLine("Hotel Product saved");
        }
    }
}
