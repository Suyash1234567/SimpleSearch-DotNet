using Microsoft.AspNetCore.Mvc;
using MovieWebApplication.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MovieWebApplication.Controllers
{
    public class MovieController : Controller
    {

        MovieViewModel movieViewModel = new MovieViewModel();
        List<Movie> movies;
        public MovieController()
        {
            MovieData objMovie = new MovieData();
            movieViewModel.MovieList = objMovie.Getata();
            movies= objMovie.Getata(); ;


        }
        public IActionResult Index()
        {
            /// <summary>
            /// Default Action result
            /// </summary>
            /// <returns></returns>
            
                
                //ViewData.Model = movieViewModel;

                return View(movieViewModel);            
        }

        [HttpPost]
        public IActionResult Index(MovieViewModel movie)
        {
            var receivedMovieId = $"{movie.MovieID}";
            int movieID = Convert.ToInt32(receivedMovieId);
            List<Movie> movieData = new List<Movie>();
            foreach (Movie item in movies)
            {
                if (item.MovieID == movieID)
                {
                    movieData.Add(item);
                }
            }
            movieViewModel.MovieList = movieData;
            Index();
            ModelState.Clear();
            return Json(movieViewModel);
        }



    }
}