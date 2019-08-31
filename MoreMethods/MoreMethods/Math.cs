using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Math
    {
        public int Addme(int number)
        {
            int totalValue;
            totalValue = number + 10;
            return totalValue;

        }
        public int Addme(decimal number)
        {
            int number1 = Convert.ToInt32(number);
            int totalValue;
            totalValue = number1 + 10;
            return totalValue;
        }
        public int Addme (string number)
        {
            int number2 = Convert.ToInt32(number);
            int totalValue;
            totalValue = number2 + 10;
            return totalValue;
        }
    }
}
