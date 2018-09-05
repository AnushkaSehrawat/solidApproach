using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class gettingtype
    {
        string itemType;
        IProduct defaultvalue=null;
        public gettingtype(string itemType)
        {
            this.itemType = itemType;
        }

        public IProduct DetermineType()
        {
            switch (itemType)
            {
                case "car":
                    return new CarProduct();
                case "hotel":
                    return new HotelProduct();

                default:
                    return defaultvalue;

            }

        }
    }
}
