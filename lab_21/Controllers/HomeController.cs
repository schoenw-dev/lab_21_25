using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab_21.Models;

namespace lab_21.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View(new Movie());
            
        }

        public IActionResult DisplayResult(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                return View("DisplayResult", newMovie);
            }
            else
            {
                return View("MovieForm", newMovie);

            }
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
