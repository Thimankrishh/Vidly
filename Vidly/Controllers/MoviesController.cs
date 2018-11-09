using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()  // this ActionResult is the base class for all action results.
        {
            var movie = new Movie {Name = "Shrek"}; // reSharper auto generates namespace for this class.
         //  return View(movie); // view is in red when there is no view called random in movies view.
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"},
            new Customer{Name = "Customer 3"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };

        //    var viewResult = new ViewResult();
          //  viewResult.ViewData.Model

            return View(viewModel);




            //  return Content("Hello world");
            //  return HttpNotFound();
            //  return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy= "name" });

        }



     /*   [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        */
     /*   public ActionResult Edit(int ids)
        {

            return Content("id" + ids);

        } 

       public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

          */

    }
}