using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Byggeprojekt_asp.net.Models;

namespace Byggeprojekt_asp.net.Controllers
{
    public class NewsController : Controller
{
    // GET: /<controller>/
    public IActionResult Index()
    {
        return View();
    }
}
}
