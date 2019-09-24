using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            const string type = "Student";
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            var names= new Concatinate();
            
            Console.WriteLine(type + " " + names.FullName(firstName,lastName));
            Console.ReadLine();


        }
    }
}


