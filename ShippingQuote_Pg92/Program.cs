using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote_Pg92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome to Package Express. Please follow the instructions below.
Please enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            if (pkgWeight < 50)
            {
                // Ask for dimensions, w/h/l
                Console.WriteLine("Please enter the package width:");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int pkgLength = Convert.ToInt32(Console.ReadLine());

                // Sum pkg w/h/l
                int pkgDimensions = (pkgWidth + pkgHeight + pkgLength);

                // Est shipping cost equals pkg dimensions times weight, divided by 100
                decimal estShipping = (pkgDimensions * pkgWeight) / 100m;

                if (pkgDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + estShipping +
                                      Environment.NewLine +
                                      "Thank you.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
