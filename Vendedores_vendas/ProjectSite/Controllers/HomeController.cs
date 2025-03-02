using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // Pegando os dados do view /home 
using ProjectSite.Models.ViewModels;

namespace ProjectSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()   // Todos eles irão retornar uma ação, neste caso uma página também.
        {
            return View();
        }

        public IActionResult About()  // É uma interface que é um supertipo para todo resultado de uma ação.
        {
            ViewData["Message"] = "Salles web MVC App from C# Course.";
            ViewData["Developer"] = "Caio Teles";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
