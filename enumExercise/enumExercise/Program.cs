﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExercise
{
    class Program
    {


        public enum WeekDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Main(string[] args)
        {


            Console.WriteLine("What is the current day of the week?");
            string currentDay = Console.ReadLine();

            try
            {
                Console.WriteLine(Enum.Parse(typeof(WeekDay), currentDay));
            }
            catch
            {
                Console.WriteLine("Please Enter an actual day of the week?");
                
            }



            Console.ReadLine();
            
        }
    }
}
