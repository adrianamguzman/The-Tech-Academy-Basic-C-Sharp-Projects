﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 5;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
