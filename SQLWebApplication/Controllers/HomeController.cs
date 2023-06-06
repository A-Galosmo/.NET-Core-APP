using Microsoft.AspNetCore.Mvc;
using SQLWebApplication.Models;
using System.Diagnostics;

namespace SQLWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        [HttpPost]
        public IActionResult ProcessUserInput(string query)
        {
            // Use the captured user input (username) in your application logic
            // For example, pass it to another method or store it in a database

            // Redirect or return a view
            return RedirectToAction("Index");
        }



    }
}