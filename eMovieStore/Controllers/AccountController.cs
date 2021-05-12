using eMovieStore.Models;
using eMovieStore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Controllers
{
    public class AccountController : Controller
    {
        //private readonly UserManager<ApplicationUser> userManager;
        //private SignInManager<ApplicationUser> signInManager;

        //public AccountController(UserManager<ApplicationUser> userManager,
        //                        SignInManager<ApplicationUser> signInManager)
        //{
        //    this.userManager = userManager;
        //    this.signInManager = signInManager;
        //}

        [HttpGet]
        [AllowAnonymous]
        public  IActionResult Login()
        {

            return View();
        }

    }
}
