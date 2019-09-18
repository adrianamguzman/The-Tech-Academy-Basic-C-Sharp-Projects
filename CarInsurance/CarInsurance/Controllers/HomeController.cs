using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(int age, string dui, int carYear, string carMake, string carModel, int tickets, string coverage)
        {
            Customer customer = new Customer();

            int runningQuote = 50;



            if (customer.Age < 25 || customer.Age > 100)
            {
                runningQuote = (runningQuote + 25);


                if (customer.Age < 18)
                {
                    runningQuote = (runningQuote + 100);



                    if (customer.CarYear < 2000 || customer.CarYear > 2015)
                    {
                        runningQuote = runningQuote + 25;


                        if (customer.CarMake == "Porche" || customer.CarMake == "porche")
                        {
                            runningQuote = runningQuote + 25;

                            if (customer.CarMake == "Porche" || customer.CarMake == "porche" && customer.CarModel == "911 Carrera" || customer.CarModel == "911 carrerra")
                            {

                                runningQuote = runningQuote + 25;

                                if (customer.Tickets > 0)
                                {
                                    runningQuote = runningQuote + (customer.Tickets * 10);


                                    if (customer.Dui == "yes" || customer.Dui == "ya" || customer.Dui == "yeah")
                                    {
                                        runningQuote = runningQuote + (runningQuote * (1 / 4));

                                        if (customer.Coverage == "full")
                                        {
                                            runningQuote = runningQuote + (runningQuote * (1 / 2));

                                        }

                                    }
                                }

                            }
                        }
                    }
                }
            }
            customer.totalQuote = runningQuote;

            return View("Quoted", customer.totalQuote);


        }

        public ActionResult Admin()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var quotes = db.CustomerQuotes;
                var Customers = new List<Customer>();
                foreach (var customer in quotes)
                {
                    CustomerQuote customersQuote = new CustomerQuote();
                    customersQuote.FirstName = customer.FirstName;
                    customersQuote.LastName = customer.LastName;
                    customersQuote.EmailAddress = customer.EmailAddress;
                    customersQuote.QuoteEstimate = Convert.ToInt32(customer.QuoteEstimate);
                    quotes.Add(customersQuote);

                }



                return View(quotes);
            }

        }
    }
}