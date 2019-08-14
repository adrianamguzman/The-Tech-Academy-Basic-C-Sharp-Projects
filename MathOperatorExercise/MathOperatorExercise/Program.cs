using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // Multiply input by 50
            Console.WriteLine("Pick a numbers between 0 and 10,000,000!");
            

            double userPick = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(userPick*50);

            // Adds 25 to input

            double userAdd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(userAdd + 25);

            //Divide inout by 12.5
            double userDivide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(userDivide/12.5);
            

            // Greater than 50

            double userGreater = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(userGreater > 50);

            // prints remainder

            double remainder = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(remainder % 7);
            Console.ReadLine();















        }
    }
}
