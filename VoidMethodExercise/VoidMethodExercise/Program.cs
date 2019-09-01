using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoidMethodExercise;

namespace VoidMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("What is your first name?");

            math.firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            math.lastName = Console.ReadLine();
            
            Console.WriteLine("Pick a number to Divide:");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());

           
            math.doMath(pickedNumber);


            Console.WriteLine(Math.FullName(math.firstName,math.lastName));
            
            Console.ReadLine();
        }


    
    }
}
