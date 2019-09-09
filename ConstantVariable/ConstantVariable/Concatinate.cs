using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariable
{
    public class Concatinate

    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Concatinate(string name) : this(name, string.Empty)
        {
        }

       

        public Concatinate(string name, string name2)
        {
            this.firstName = name;
           
            this.lastName = name2;
        }


    }
}
