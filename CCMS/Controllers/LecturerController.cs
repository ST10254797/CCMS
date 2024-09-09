using Microsoft.AspNetCore.Mvc;

namespace CCMS.Controllers
{
    public class LecturerController : Controller
    {
        // Load the claim submission form
        public IActionResult SubmitClaim()
        {
            return View();
        }

        // Load the claim track form
        public IActionResult TrackClaim()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
  //References:
    //Bootstrap, ND. Build fast, responsive sites with Bootstrap. [Online]. Available at: https://getbootstrap.com/ (Accessed 5 September 2024)
