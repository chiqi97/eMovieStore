using eMovieStore.Models;
using eMovieStore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMovieStore.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace eMovieStore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository,
             IWebHostEnvironment hostingEnviroment)
        {
            _movieRepository = movieRepository;
            _hostingEnvironment = hostingEnviroment;
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

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MovieCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                Movie newMovie = new Movie
                {
                    Title = model.Title,
                    Author = model.Author,
                    Genre = model.Genre,
                    Description = model.Description,
                    YearOfProduction = model.YearOfProduction,
                    Price = model.Price,
                    PhotoPath=uniqueFileName

                };
                _movieRepository.Add(newMovie);
                return RedirectToAction("details", new { id = newMovie.Id });
            }
            return View();
        }

        private string ProcessUploadedFile(MovieCreateViewModel model)
        {
            string uniqueFileName = null;



            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }



            }

            return uniqueFileName;

        }


    }
}
