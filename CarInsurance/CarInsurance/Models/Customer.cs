using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
        public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
     
        public int totalQuote { get; set; }

    }
}

//public string Dui { get; set; }
//public int Age { get; set; }
//public int CarYear { get; set; }
//public string CarMake { get; set; }
//public string CarModel { get; set; }
//public int Tickets { get; set; }
//public string Coverage { get; set; }