using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Adriana \"Marie\" Guzman";

            fullName = fullName.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append("I am writing a paragraph for thsi exercise");
            sb.Append("\nIt is taking a second to do it line by line.");
            sb.Append("\nHowever, It is turning out to be kind of fun though!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
