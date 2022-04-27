using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio3.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var Movies = GetListOfMovies();
            ViewBag.MainTitle = "List of my favorite films";
            return View(Movies);
        }

        private List<MovieModel> GetListOfMovies()
        {
            List<MovieModel> movies = new List<MovieModel>();
            movies.Add(new MovieModel { Id = 1, Name = "Shrek", Genre = "Family/Comedy/Adventure", ReleasedDate = new DateTime(2001, 5, 18) });

            movies.Add(new MovieModel { Id = 1, Name = "The Lord of the Rings: The Fellowship of the Ring", 
                Genre = "Action/Fantasy/Adventure", ReleasedDate = new DateTime(2001, 12, 19) });

            movies.Add(new MovieModel { Id = 1, Name = "Parasite", Genre = "Thriller/Drama", ReleasedDate = new DateTime(2019, 5, 30) });
            
            return movies;
        }
    }
}
