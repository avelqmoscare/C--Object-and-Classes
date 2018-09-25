using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndObjectProject
{

    //LaptopSpecification is the other class we've created that will inherit methods and
    //variables from AdditionalLaptopInfo class

    class LaptopSpecification : AdditionalLaptopInfo
    {
        //Summary  (parameters) this functio accepts complte set of parameters and
        //returns the summary of specification.

        public string Summary(string brand, string VideoCard, string Memory, bool WithCamera,
            string ScreenType, string speaker, string Processor)
        {
            string SummarySpecification = String.Empty;
            string Camera = String.Empty;


            if (WithCamera == true)
            {
                Camera = "Yes";
            }

            else
            {
                Camera = "No";
            }

            SummarySpecification = "Brand: " + brand + Environment.NewLine +
                "VideoCard: " + VideoCard + Environment.NewLine +
                "Memory: " + Memory + Environment.NewLine +
                "With Camera: " + Camera + Environment.NewLine +
                "ScreenType: " + speaker + Environment.NewLine +
                "Processor: " + Processor + Environment.NewLine;


            //Since we inherit from AddionalLoptapInfo CLass, we can call
            //its function "AddtionalLaptopInfoSummary".

            SummarySpecification = SummarySpecification + AdditionalLaptopInfoSummary(31500, "Makati");
            return SummarySpecification;
        }
    }
}
