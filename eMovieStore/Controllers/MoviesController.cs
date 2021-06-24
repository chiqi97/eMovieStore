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
using eMovieStore.Models.MovieRelated;

namespace eMovieStore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IMovieRepository _movieRepository;
        private readonly AppDbContext _context;

        public MoviesController(IMovieRepository movieRepository,
             IWebHostEnvironment hostingEnviroment,
             AppDbContext context)
        {
            _movieRepository = movieRepository;
            _hostingEnvironment = hostingEnviroment;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchTitle, int p=1,string movieGenre="All")
        {
            int pageSize = 6;

            if (searchTitle != null &&
                searchTitle != "")
            {
                var movies = _movieRepository.GetMoviesByName(searchTitle).OrderByDescending(x=>x.Id)
                     .Skip((p - 1) * pageSize).Take(pageSize);
                return View(movies);
            }
            var movies1 = _movieRepository.GetMoviesByGenre(movieGenre)
                .Skip((p - 1) * pageSize).Take(pageSize);

            MovieGroupViewModel moviesGroupVM = new MovieGroupViewModel(movies1.ToList(),
                p,
                pageSize,   
                (int)Math.Ceiling((decimal)_movieRepository.GetMoviesByGenre(movieGenre).Count() / pageSize),
                movieGenre
                );

            return View(moviesGroupVM);
        }





        [HttpGet]
        public ViewResult Details(int? id)
        {
            Movie movie = _movieRepository.GetMovie(id.Value);
            if (movie == null)
            {
                Response.StatusCode = 404;
                return View("MovieNotFound", id.Value);
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

        [HttpGet]
        public ViewResult Delete(int id)
        {
            _movieRepository.Delete(id);
            return View("deleted");
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
