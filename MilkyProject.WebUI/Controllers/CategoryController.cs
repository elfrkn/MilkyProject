using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.Category;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
       
        public ActionResult Index()
        {
           
            return View();

        }

    }
}
