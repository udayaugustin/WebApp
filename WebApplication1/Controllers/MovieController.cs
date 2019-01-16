using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customer = new List<Customer>
            {
                new Customer{Name="Cus1"},
                new Customer{Name="Cus2"}
            };

            var viewModel = new MovieViewModel { Movie = movie, Customers = customer };

            return View(viewModel);
        }

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
               new Movie{Name="Shark"},
               new Movie{Name="Wall-e"}
            };

            var viewModel = new MovieViewModel { MovieList = movies };

            return View(viewModel);
        }

        [Route("movie/release/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {


            return Content("year=" + year + " month=" + month);
        }

    }
}