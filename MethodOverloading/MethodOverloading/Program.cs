using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodOverloading;

namespace MethodOverloading
{
    class Program
    {
      
    static void Main(string[] args)
        {

            Math math = new Math();
            Console.WriteLine("Pick two numbers");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());
            int pickedNumber2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Your total value is : " + math.Function(number: pickedNumber, number2: pickedNumber2));
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Thank you " + math.Function(name: name));
            Console.ReadLine();
        }

    } 
}
