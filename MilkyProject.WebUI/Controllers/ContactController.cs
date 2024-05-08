using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.Contact;
using MilkyProject.WebUI.DTOs.Newsletter;
using MilkyProject.WebUI.DTOs.Product;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Controllers
{
    public class ContactController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7166/api/Contact", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("CreateContact");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewsletter(CreateNewsletterDto createNewsletterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createNewsletterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7166/api/Newsletter", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Default");
            }
            return View();
        }

    }
}
