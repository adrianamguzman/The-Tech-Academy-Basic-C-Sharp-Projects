using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariable
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name)
            {
                Name = name; 

            }
            public Person(string name, int age) : this(name)
            {
                
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            const string type = "Student";
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();


            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name,age);
            Console.WriteLine(type+ ":" +person.Name + " is " +person.Age);
            Console.ReadLine();

        }
    }
}





