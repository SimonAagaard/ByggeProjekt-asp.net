using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Byggeprojekt_asp.net.Models;

namespace Byggeprojekt_asp.net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Om os side";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Kontakt side";

            return View();
        }

        public IActionResult FAQ()
        {
            ViewData["Message"] = "Ofte stillede spørgsmål";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
