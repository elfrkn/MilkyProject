using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs;
using MilkyProject.WebUI.DTOs.Category;
using MilkyProject.WebUI.DTOs.Product;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MilkyProject.WebUI.Controllers
{
    public class ProductController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
    }
}
