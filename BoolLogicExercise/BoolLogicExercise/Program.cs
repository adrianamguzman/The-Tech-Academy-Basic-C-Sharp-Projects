using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolLogicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your age?");
            int age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? true or false");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");

            int tickets = Convert.ToInt32(Console.ReadLine());

            // does the applicant qualify for car insurance?

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);
            Console.ReadLine();







        }
    }
}
