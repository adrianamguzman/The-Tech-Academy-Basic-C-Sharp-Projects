using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    public class Employee<T> : Person, IQuittable
    {
        public List<T> Things { get; set; }
        public int ID { get; set; }
        public override void SayName()
        {
            base.SayName();
        }

      
        public void Quit()
        {
            Console.WriteLine("I quit.");
        }

       



    }
}
