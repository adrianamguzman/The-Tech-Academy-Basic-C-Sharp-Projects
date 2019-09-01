using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodExercise
{
    class Math
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    
        public void doMath(int number)
        {
            int totalValue;
            totalValue = number / 2;
            Console.WriteLine(number + "/2 =" + totalValue);

        }

        public static string FullName(string firstName, string lastName)

            {
            string totalName = "that is your answer " + firstName + " " + lastName;
            return totalName ;

            }   
        
    }
}
