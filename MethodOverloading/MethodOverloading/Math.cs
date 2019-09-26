using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Math
    {
        public int Function(int pickedNumber, int pickedNumber2)
        {
            int totalValue;
            totalValue = pickedNumber + pickedNumber2;
            return totalValue;

        }

        public string Function(string name)
        {

            string var = name;
            return var;
        }


    }
}
