using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of your choice: ");
            string number = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Adriana\source\logPractice.txt", number);

            string text = File.ReadAllText(@"C:\Users\Adriana\source\logPractice.txt");

            System.Console.WriteLine("Contents of logPractice.txt = {0}", text);

            Console.ReadLine();

        }
    }
}
