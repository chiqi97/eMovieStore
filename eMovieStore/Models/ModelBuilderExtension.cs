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
        YearOfProduction=2010,
        Description= "Szeryf federalny Daniels stara się dowiedzieć, jakim sposobem z zamkniętej " +
        "celi w pilnie strzeżonym szpitalu dla chorych psychicznie przestępców zniknęła pacjentka.",
        Price=5.23,
        PhotoPath="shutter-island.jpg"
        
    },
    new Movie
    {
        Id = 2,
        Title = "Skazani na Shawshank",
        Author = "Frank Darabont",
        Genre = "Dramat",
        YearOfProduction=1994,
        Description = "Adaptacja opowiadania Stephena Kinga. Niesłusznie skazany na dożywocie bankier, " +
        "stara się przetrwać w brutalnym, więziennym świecie.",
        Price = 35.24,
        PhotoPath ="skazani.jpg"
        
    }
    );
        }
    }
}
