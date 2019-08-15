using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            // Person number 1
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate?");

            double person1Hourly = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many hours are worked per week?");

            double person1Worked = Convert.ToDouble(Console.ReadLine());

            double person1Total = person1Hourly * person1Worked;

            Console.WriteLine("Weekly Salary for person one: $" + person1Total);
            Console.ReadLine();

            //Person number 2

            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");

            double person2Hourly = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many hours are worked per week?");

            double person2Worked = Convert.ToDouble(Console.ReadLine());

            double person2Total = person1Hourly * person1Worked;

            Console.WriteLine("Weekly Salary for person two: $" + person1Total);
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more than Person 2?");
            Console.WriteLine(person1Total > person2Total);

            Console.ReadLine();







        }
    }
}
