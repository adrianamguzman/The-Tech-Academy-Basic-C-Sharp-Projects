using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1,2,3,4,5};
            Console.WriteLine("Choose a number:");

            try
            {

                decimal numberPicked = Convert.ToDecimal(Console.ReadLine());

                foreach (int number in numbers)
                {

                    decimal total = numberPicked / number;
                    Console.WriteLine(total);
                 
                }
      
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                Console.ReadLine();
                return;
            }
            

            Console.ReadLine();
        }
            
    }
}
