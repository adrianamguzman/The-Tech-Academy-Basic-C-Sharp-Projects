using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolComparisonExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Value of Your number: {0}", number);
                number = number + 1;

            } while (number < 10 );
                Console.ReadLine();


            Console.WriteLine(" Are you hungry? true or fasle?");
            bool hunger = Convert.ToBoolean(Console.ReadLine());

            while (!hunger)
            {
                Console.WriteLine("Okay, Ill ask again later");
                break;
                   
            }














            Console.ReadLine();
        }
    }
}



