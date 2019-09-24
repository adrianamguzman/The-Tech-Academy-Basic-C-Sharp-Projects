using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariable
{
    public class Concatinate

    {
        public string Name{ get; set; }
       


        public string FullName(string name, string name2)
        {
            this.Name = name +" "+ name2;
            return this.Name;
           
            
        }


    }
}
