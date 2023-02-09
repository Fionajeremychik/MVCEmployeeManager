using Microsoft.AspNetCore.Mvc;

namespace MVCEmployeeManager.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
