using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Models
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext context;

        public MovieRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Movie Add(Movie book)
        {
            context.Movies.Add(book);
            context.SaveChanges();
            return book;
        }

        public Movie Delete(int id)
        {
            Movie book =context.Movies.Find(id);
            if (book != null)
            {
                context.Movies.Remove(book);
                context.SaveChanges();
            }
            return book;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return context.Movies;
        }

        public IEnumerable<Movie> GetMoviesByGenre(string genre)
        {
            if (genre == "All")
            {
                return context.Movies;
            }
            return context.Movies.Where(x=>x.Genre==genre);
        }
        public IEnumerable<Movie> GetMoviesByName(string name)
        {
            return context.Movies.Where(x=>x.Title.Contains(name));
        }

        public Movie GetMovie(int id)
        {
            return context.Movies.Find(id);
        }

        public Movie Update(Movie bookChanges)
        {
            var book = context.Movies.Attach(bookChanges);
            book.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return bookChanges;
        }
    }
}
