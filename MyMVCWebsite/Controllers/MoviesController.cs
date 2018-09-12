using MyMVCWebsite.Models;
using MyMVCWebsite.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCWebsite.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie();
            movie.Name = "Shrik";


            var customers = new List<Customer> {

               new Customer{ Id=1,Name="Customer1"},
               new Customer{ Id=2,Name="Customer2"}

        };

            var randomMovieViewModel = new RandomMovieViewModel {

                Movie = movie,


                Customers = customers
                
            };

            //return RedirectToAction("Index", "Home");
            return View(randomMovieViewModel);
        }

        public ActionResult Edit(int id)
        {

            return Content("ID =" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {

            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content("Page index= " + pageIndex + "SortBy: " + sortBy);
        }

        // Attribute Routing
        [Route("Movies/Released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ReleasedDate(int year, int month)
        {




            return Content(year + " - " + month);

        }



    }
}