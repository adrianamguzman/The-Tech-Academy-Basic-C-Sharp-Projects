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
            List<int> numbers = new List<int> {100,50,30,20,10};

        Math:
            try
            {
                Console.WriteLine("Choose a number:");

                decimal numberPicked = Convert.ToDecimal(Console.ReadLine());

                foreach (int number in numbers)
                {

                    decimal total = number / numberPicked;
                    Console.WriteLine(total);

                }

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Tried to Divide by Zero, Please pick again");
                

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Something was entered inorrectly, please enter a whole number");
                   
            }
            Console.WriteLine("A Try Catch Block has been Successfully Executed, Continue with the program until Finished..");
            goto Math;



        }
            
    }
}
