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

            var fullName = new Concatinate(lastName,firstName);
            Console.WriteLine("{0} : {1} {2}", type, firstName, lastName);
            Console.ReadLine();

         

        }
    }
}


// ** yes i know no real concatinating was done in this code hahah