using Bartender_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bartender_App.Controllers
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

        public IActionResult Drinks()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Submit(string name)
        {
            ViewBag.Name = name;
            return View("Index");
        }

        public IActionResult Queue()
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