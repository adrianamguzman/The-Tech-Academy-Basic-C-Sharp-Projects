using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()

        {
            using (CarInsuranceEntities1 db = new CarInsuranceEntities1())
            {
                var customerList = db.CustomerQuotes;
                var customers = new List<CustomerQuote>();
                foreach (var customer in customerList)
                {
                    var customersQuote = new CustomerQuote();
                    customersQuote.FirstName = customer.FirstName;
                    customersQuote.LastName = customer.LastName;
                    customersQuote.EmailAddress = customer.EmailAddress;
                    customersQuote.QuoteEstimate = customer.QuoteEstimate;
                    customers.Add(customersQuote);

                }



                return View(customers);
            }
        }
    }
}