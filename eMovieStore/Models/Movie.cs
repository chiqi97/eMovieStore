using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Models
{
    public class Movie
    {
        public int Id { get; set; }
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
        [Display(Name = "Autor")]
        public string Author { get; set; }
        [Required]
        [Display(Name = "Opis filmu")]
        public string Description { get; set; }
        [Required]
        [MaxLength(4)]
        [Display(Name = "Rok Produkcji")]
        public int YearOfProduction { get; set; }

        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        //Check if wrote number is correct for price
        [RegularExpression("(\\d+\\.\\d{2})", ErrorMessage = "Podaj poprawną cenę")]
        //[Column(TypeName = "decimal(6,2)")]
        [Display(Name = "Cena")]
        public double Price { get; set; }
        public string PhotoPath { get; set; }

    }
}
