using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1"},
                new Customer {Name="Customer 2"}

                
            };
            
            var ViewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);

        }
        public ActionResult Edit(int id)
        {
            return Content("ID: " + id);
        }

        // /Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = GetMovies();

            return View(movies);

        } 

        [Route("movies/released/ByReleaseYear/{year}/{month:range(1,12)}")]
        public ActionResult ByReleaseYear(int year,int month)
        {
            return Content(year + "/" + month);

        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
             {
                 new Movie { Id = 1, Name = "Shrek" },
                 new Movie { Id = 2, Name = "Wall-e" }
             };
        }
    }
}