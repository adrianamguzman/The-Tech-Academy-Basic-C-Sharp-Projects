using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() {"Adriana", "Bill", "Kate"};

            foreach (string employees in employee.Things)
            {
                Console.WriteLine(employees);
            }

            

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 01, 02, 03,04};

            foreach (int employees1 in employee1.Things)
            {
                Console.WriteLine(employees1);
            }

            Console.ReadLine();


            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.ID = 00000;



            //employee.SayName();
            //IQuittable quit = new Employee<String>();
            //quit.Quit();

            Console.Read();

        }
    }
}
