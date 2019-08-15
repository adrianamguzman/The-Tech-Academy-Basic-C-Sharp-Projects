using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped Via Package Express. Have a good day!");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
            }

            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int packageDimensions = packageWidth + packageHeight + packageLength;
            int packageCost = (packageDimensions * packageWeight) / 100;

            if (packageDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day!");
            }
            else 
            {
                Console.WriteLine("Your estimated total for shipping is: $" + packageCost);
            }

            Console.ReadLine();







        }
    }
}
