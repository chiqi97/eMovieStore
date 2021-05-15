using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.ViewModels
{
    public class RegisterViewModel
    {
        //[Required]
        //public string UserName { get; set; }
        [Required]
        [EmailAddress]

        //[ValidEmailDomain (allowedDomain: "o2.pl", 
        //    ErrorMessage ="email domain must be o2.pl")] // dozwolone maile tylko 02 utitlities
        // allow domain wysylany do validemailDomain
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password",
                ErrorMessage = "Password and confirmation password dont match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
    }
}
