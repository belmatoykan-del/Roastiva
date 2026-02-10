using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Roastiva.Models;

namespace Roastiva.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            ViewData["BodyClass"] = "home-page";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Process()
        {
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
