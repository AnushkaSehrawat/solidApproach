using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string itemType;
            Console.WriteLine("Enter the type of product you want to book:");
            itemType = Console.ReadLine();
          
            gettingtype obj = new gettingtype(itemType);
            IProduct finalObject = obj.DetermineType();
            if (finalObject != null)
            {
                finalObject.GetTypeOfProduct();
                finalObject.Book();
                finalObject.Save();
            }
            else
            {
                Console.WriteLine("The provided type does not exists.");
            }
            Console.ReadKey();
        }
    }
}
