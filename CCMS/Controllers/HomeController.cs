using CCMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CCMS.Controllers
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
    }
}
  //References:
    //Bootstrap, ND. Build fast, responsive sites with Bootstrap. [Online]. Available at: https://getbootstrap.com/ (Accessed 5 September 2024)
