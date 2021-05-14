using eMovieStore.Models;
using eMovieStore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMovieStore.ViewModels;

namespace eMovieStore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            var model = _movieRepository.GetAllMovies();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            Movie movie = _movieRepository.GetMovie(id);
            if (movie == null)
            {
                return View("NotFound", id);
            }
            MovieDetailsViewModel movieViewModel = new MovieDetailsViewModel()
            {
                Movie=movie
            };

            return View(movieViewModel);

        }
    }
}
