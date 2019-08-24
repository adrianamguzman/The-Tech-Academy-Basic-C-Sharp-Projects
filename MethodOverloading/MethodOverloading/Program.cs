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

            MethodOverloading.Math math = new Math();
            Console.WriteLine("Pick two numbers to Add:");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());
            int pickedNumber2 = Convert.ToInt32(Console.ReadLine());

            int total = math.Addme(pickedNumber, pickedNumber2);
            Console.WriteLine("Yout total value is : " + total);
            Console.ReadLine();
        }
    } 
}
