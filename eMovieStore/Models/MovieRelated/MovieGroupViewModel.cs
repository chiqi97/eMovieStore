using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Models.MovieRelated
{
    public class MovieGroupViewModel
    {

        public List<Movie> Movies { get; set; }
        public int PageNumber { get; set; }
        public int PageRange { get; set; }
        public int TotalPages { get; set; }
        public string Genre { get; set; }
        public MovieGroupViewModel(List<Movie> movies, int pageNumber,int pageRange, int totalPages,string genre)
        {
            Movies = movies;
            PageNumber = pageNumber;
            PageRange = pageRange;
            TotalPages = totalPages;
            Genre = genre;

        }

    }
}
