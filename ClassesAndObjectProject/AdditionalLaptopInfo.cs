using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndObjectProject
{
    class AdditionalLaptopInfo
    {
        public string AdditionalLaptopInfoSummary(double price, string storeLocation)
        {
            string Additionalinfo;
            Additionalinfo = "Price: " + price + Environment.NewLine + "Store Location: " + storeLocation + Environment.NewLine;
            return Additionalinfo;

        }
    }
}
