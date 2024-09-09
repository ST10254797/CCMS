using Microsoft.AspNetCore.Mvc;

namespace CCMS.Controllers
{
    public class CoordinatorController : Controller
    {
        // Load the review claims page for coordinators
        public IActionResult ReviewClaims()
        {
            return View();
        }
    }
}
  //References:
    //Bootstrap, ND. Build fast, responsive sites with Bootstrap. [Online]. Available at: https://getbootstrap.com/ (Accessed 5 September 2024)
