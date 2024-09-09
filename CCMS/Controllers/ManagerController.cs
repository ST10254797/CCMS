using Microsoft.AspNetCore.Mvc;

namespace CCMS.Controllers
{
    public class ManagerController : Controller
    {
        // Load the approve claims page for academic managers
        public IActionResult ApproveClaims()
        {
            return View();
        }
    }
}
  //References:
    //Bootstrap, ND. Build fast, responsive sites with Bootstrap. [Online]. Available at: https://getbootstrap.com/ (Accessed 5 September 2024)
