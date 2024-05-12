using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.Contact;
using Newtonsoft.Json;
using System.Net.Http;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var clientContact = _httpClientFactory.CreateClient();
            var responseMessageContact = await clientContact.GetAsync("https://localhost:7166/api/Contact/GetContactCount");

            var clientNewsletter = _httpClientFactory.CreateClient();
            var responseMessageNewsletter = await clientNewsletter.GetAsync("https://localhost:7166/api/Newsletter/GetNewsletterCount");

            var clientEmployer = _httpClientFactory.CreateClient();
            var responseMessageEmployer = await clientEmployer.GetAsync("https://localhost:7166/api/Employer/GetEmployerCount");

            var clientCategory = _httpClientFactory.CreateClient();
            var responseMessageCategory = await clientCategory.GetAsync("https://localhost:7166/api/Category/GetCategoryCount");

            if (responseMessageContact.IsSuccessStatusCode)
            {
                var jsonDataContact = await responseMessageContact.Content.ReadAsStringAsync();
                ViewBag.ContactCount = jsonDataContact;

                var jsonDataNewsletter = await responseMessageNewsletter.Content.ReadAsStringAsync();
                ViewBag.NewsletterCount = jsonDataNewsletter;

                var jsonDataEmployer = await responseMessageEmployer.Content.ReadAsStringAsync();
                ViewBag.NewsletterCount = jsonDataEmployer;

                var jsonDataCategory = await responseMessageCategory.Content.ReadAsStringAsync();
                ViewBag.NewsletterCount = jsonDataCategory;

                return View();
            }
            return View();
        }
    }
}
