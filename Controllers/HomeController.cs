using MindBlowing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MindBlowing.Controllers
{
    public class HomeController : Controller
    {
        [Route("customer/{details}/{id:int}")]
        public ActionResult Customer()
        {
            var listOfCustomers = new List<Customer>()
            {
                new Customer{CustomerID=1,Name="Lagaan"},
                new Customer{CustomerID=2,Name="3 Idiots"}
            };
            return View(listOfCustomers);

        }
    }
}