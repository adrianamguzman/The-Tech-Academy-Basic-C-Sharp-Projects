using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodsExercise;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodsExercise.Math math = new Math();
            Console.WriteLine("Pick a number to Add:");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(math.Addme(pickedNumber));

            
            Console.WriteLine("Pick a number to divide:");
            int pickedNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.DivideMe(pickedNumber2));


            Console.WriteLine("Pick a number to Multiply:");
            int pickedNumber3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.MultiplyMe(pickedNumber3));


            Console.ReadLine();
        }
        
    }
    

}
