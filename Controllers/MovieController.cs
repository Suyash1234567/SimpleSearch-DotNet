using Microsoft.AspNetCore.Mvc;
using MovieWebApplication.Models;
using System.Collections;

namespace MovieWebApplication.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            /// <summary>
            /// Default Action result
            /// </summary>
            /// <returns></returns>
            
                MovieData objMovie = new MovieData();
                var movie = objMovie.Getata();
                ViewData.Model = movie;

                return View();
            
           
        }
    }
}