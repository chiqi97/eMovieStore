using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Models
{
   public interface IMovieRepository
    {
        Movie GetMovie(int Id);
        IEnumerable<Movie> GetAllMovies();
        Movie Add(Movie book);
        Movie Update(Movie bookChanges);
        Movie Delete(int id);
        IEnumerable<Movie> GetMoviesByGenre(string genre);
    }
}
