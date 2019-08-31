using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleParameters;

namespace MultipleParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();
            Console.WriteLine("Pick a number to Add:");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number(optional):");
            try
            {

                int pickedNumber2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {


                Console.WriteLine("Your total numer is: " + math.Addme(pickedNumber));
            }
            Console.ReadLine();
        }
            
            
        
    
    }
}
