using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(

    new Movie
    {
        Id = 1,
        Title = "Wyspa tajemnic",
        Author = "Martin Scorsese",
        Genre = "Thriller",
        YearOfProduction=2010
    },
    new Movie
    {
        Id = 2,
        Title = "Skazani na Shawshank",
        Author = "Frank Darabont",
        Genre = "Dramat",
        YearOfProduction=1994
        
    }
    );
        }
    }
}
