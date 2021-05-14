using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.ViewModels
{
    public class MovieViewModel
    {
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [Display(Name = "Gatunek")]
        public string Genre { get; set; }
        [Display(Name = "Autor")]
        public string Author { get; set; }
        [Display(Name = "Cena")]
        public int YearOfProduction { get; set; }
        public string ReturnUrl { get; set; }
    }
}
