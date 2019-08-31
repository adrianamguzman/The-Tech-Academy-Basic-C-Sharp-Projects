using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreMethods;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                MoreMethods.Math math = new Math();

            try
            {
                Console.WriteLine("Pick an integer to Add:");


                int pickedNumber = Convert.ToInt32(Console.ReadLine());


             
                    Console.WriteLine(math.Addme(pickedNumber));



                    Console.WriteLine("Pick a decimal to Add:");
                    decimal pickedNumber2 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine(math.Addme(pickedNumber2));

               
            }
            catch
            {
               
                string pickedNumber3 = Console.ReadLine();

                Console.WriteLine(math.Addme(pickedNumber3));
            }

                Console.ReadLine();


            
        }
    }
}
