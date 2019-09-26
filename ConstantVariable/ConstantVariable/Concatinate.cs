using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariable
{
    public class Concatinate

    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set;l }

        
        
        public string FullName(string name, string name2)
        {
            this.FirstName = name;
            this.LastName = name2;

            string FullName = this.FirstName + this.LastName;
            return FullName;

        }

        public string FullName(string name)
        {
           
        }


    }
}
