using MindBlowing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MindBlowing.Controllers
{
    public class MindBlowingController : Controller
    {
        // GET: MindBlowing
        [Route("MindBlowing/customers")]
        public ActionResult Customer()
        {
            return View(new CustomerViewModel());
        }

        [Route("MindBlowing/customers/{customerID:range(1,2)}")]
        public ActionResult CustomerDetails(int customerID)
        {
            var listOfCustomers = new List<Customer>()
            {
                new Customer{CustomerID=1,Name="Manish"},
                new Customer{CustomerID=2,Name="Bindu"}
            };
            return View(new CustomerDetailViewModel(listOfCustomers[customerID-1].CustomerID, listOfCustomers[customerID-1].Name));
        }

        [Route("Mindblowing/Movies")]
        public ActionResult Movies()
        {
            return View(new MovieViewModel());
        }

        [Route("MindBlowing/Movies/{movieId:range(1,2)}")]
        public ActionResult MovieDetails(int movieId)
        {
            var listOFMovies = new List<Movie>()
            {
                new Movie(){ MoviewId=1,MovieName="Lagaan"},
                new Movie(){ MoviewId=2,MovieName="3 Idiot" }
            };
            return View(new MovieDetailsViewModel(listOFMovies[movieId - 1].MoviewId, listOFMovies[movieId - 1].MovieName));
        }
    }
}