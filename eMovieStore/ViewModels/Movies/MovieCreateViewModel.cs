using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.ViewModels
{
    public class MovieCreateViewModel
    {
        [Required]
        [MaxLength(70)]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Gatunek")]
        public string Genre { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Reżyser")]
        public string Author { get; set; }
        [Required]
        [Display(Name = "Opis filmu")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Rok Produkcji")]
        public int YearOfProduction { get; set; }

        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        
        [Display(Name = "Cena")]
        public double Price { get; set; }
        [Display(Name = "Zdjęcie")]
        public IFormFile Photo { get; set; }
    }
}
