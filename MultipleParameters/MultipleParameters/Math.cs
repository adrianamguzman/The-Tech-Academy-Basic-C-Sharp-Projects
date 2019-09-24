using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleParameters
{
    class Math
    {
        public int Addme(int number, int number2 =0 )
        {
            int totalValue;
            totalValue = number + Convert.ToInt32(number2) + 10;
            return totalValue;

        }
    }
}
