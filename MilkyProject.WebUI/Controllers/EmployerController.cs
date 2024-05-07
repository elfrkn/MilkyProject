using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Controllers
{
    public class EmployerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
