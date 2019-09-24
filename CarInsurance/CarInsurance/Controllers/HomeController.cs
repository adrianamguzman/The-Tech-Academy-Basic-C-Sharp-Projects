using CarInsurance.Models;
using System;
using System.Collections.Generic;
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
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress,int age, string dui, int carYear, string carMake, string carModel, int tickets, string coverage)
        {
            

            int runningQuote = 50;


            if (age < 18)
            {

                runningQuote = (runningQuote + 100);

            }

            else if (age < 25 || age > 100)
            {
                runningQuote = (runningQuote + 25);
            }


            if (carYear < 2000 || carYear > 2015)
            {
                runningQuote = runningQuote + 25;
            }


            if (carMake == "Porche" || carMake == "porche")
            {
                runningQuote = runningQuote + 25;
            }

            if (carMake == "Porche" || carMake == "porche" && carModel == "911 Carrera" || carModel == "911 carrera")
            {

                runningQuote = runningQuote + 25;
            }
            if (tickets > 0)
            {
                runningQuote = runningQuote + (tickets * 10);
            }


            if (dui == "yes" || dui == "ya" || dui == "yeah")

            {
                runningQuote = runningQuote + (runningQuote * (1 / 4));
            }

            if (coverage == "full")
            {
                runningQuote = runningQuote + (runningQuote * (1 / 2));

            }
            ViewBag.text = coverage;

            using (CarInsuranceEntities1 db = new CarInsuranceEntities1())
            {
                var customer = new CustomerQuote();
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.EmailAddress = emailAddress;
                customer.QuoteEstimate = runningQuote;

                db.CustomerQuotes.Add(customer);
                db.SaveChanges();
            }

                return View("Quoted", runningQuote);

        }


       

        
    }
}