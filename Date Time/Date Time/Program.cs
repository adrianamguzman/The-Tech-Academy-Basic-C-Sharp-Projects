using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
           

            Console.WriteLine("Enter a number of hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine(futureTime);
            Console.ReadLine();


        }
    }
}
