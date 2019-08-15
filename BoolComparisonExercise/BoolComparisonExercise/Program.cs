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
            Console.WriteLine("How hot is it outside?");
            int temperature = Convert.ToInt32(Console.ReadLine());
            bool adventureTime = temperature == 82;

            do
            {
                switch (temperature)
                {
                    case 50:
                        Console.WriteLine("Its far too cold, but not enough for snow!");
                        Console.WriteLine("How hot is it outside?");
                        temperature = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 60:
                        Console.WriteLine("It's perect fair weather hiking day!");
                        Console.WriteLine("How hot is it outside?");
                        temperature = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 82:
                        Console.WriteLine("It's the perfect weather! go adventure!");
                        adventureTime = true;
                        break;


                    default:
                        Console.WriteLine("Not Quite the time!");
                        Console.WriteLine("How hot is it outside?");
                        temperature = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (!adventureTime);

            Console.ReadLine();
        }
    }
}



