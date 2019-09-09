using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            
        try
            {
                Console.Write("What is your age?  ");
                int age = Convert.ToInt32(Console.ReadLine());
                while (age > 0)
                {
                    var yearofBirth = DateTime.Now.AddYears(-age);
                    Console.WriteLine(yearofBirth);
                    Console.ReadLine();
                }
                if(age <= 0)
                {
                    throw new FormatException();

                }
            }    
            
            catch (FormatException) {
                Console.WriteLine("Invalid Entry, Remember! no Zeros or Negative Number! ");
                Console.ReadLine();
                return;
                
            }
            catch (Exception)
            {
                Console.WriteLine("An Error has occurred. Please contact System Admin.");
                Console.ReadLine();
                return;
            }

           
        }


    }
}
