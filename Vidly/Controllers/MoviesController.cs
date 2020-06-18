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
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(){Id = 1,Name = "Incepcja"},
                new Movie(){Id = 2,Name = "Batman"}
            };

        }

        //// GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name="Shrek" };
        //  //  var viewResult = new ViewResult();
        //   // viewResult.ViewData.Model = movie;

        //   var customers = new List<Customer>
        //   {
        //       new Customer {Name = "Customer1"},
        //       new Customer {Name = "Customer2"}
        //   };
        //   var viewModel = new RandomMoviewViewModel
        //   {
        //       Movie = movie,
        //       Customers = customers
        //   };
        //    return View(viewModel);
        //    //return Content("Hello world");
            
        //}

        
        //public ActionResult Edit(int id)
        //{
        //    return Content("id="+id);
        //}

        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content("");

        //}
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year+"/"+month);
        //}
    }
}