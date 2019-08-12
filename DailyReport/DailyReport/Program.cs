using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            string help = Console.ReadLine();
            bool helpOut = Convert.ToBoolean(help);

            Console.WriteLine("Where there any positive experieces you'd like to share? Please give specifics");
            string pExpereiences = Console.ReadLine();

            Console.WriteLine("Is there any feedback you'd like to provide? PLease be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            string hoursOfStudy = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
