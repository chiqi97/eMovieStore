using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.ViewModels
{
    public class LoginViewModel
    {
        //[Required]
        //public string UserName { get; set; }

        public string Email { get; set; }
        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Zapamiętaj mnie")]

        public bool RememberMe { get; set; }

  
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
