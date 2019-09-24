using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Math
    {
        public int Function(int number, int number2)
        {
            int totalValue;
            totalValue = number + number2;
            return totalValue;

        }

        public string Function(string variable)
        {

            string var = variable;
            return var;
        }


    }
}
