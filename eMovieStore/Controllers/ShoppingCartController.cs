using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        public ShoppingCartController()
        {


        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
