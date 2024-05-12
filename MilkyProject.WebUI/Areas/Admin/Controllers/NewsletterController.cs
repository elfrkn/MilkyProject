using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.Category;
using MilkyProject.WebUI.DTOs.Newsletter;
using MilkyProject.WebUI.DTOs.Product;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsletterController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public NewsletterController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> NewsletterList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7166/api/Newsletter");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultNewsletterDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> DeleteNewsletter(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7166/api/Newsletter?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("NewsletterList");
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewsletter()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateNewsletter(CreateGalleryDto createNewsletterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createNewsletterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7166/api/Newsletter", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("NewsletterList");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateNewsletter(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7166/api/Newsletter/GetNewsletter?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateNewsletterDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateNewsletter(UpdateNewsletterDto updateNewsletterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateNewsletterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7166/api/Newsletter", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("NewsletterList");
            }
            return View();
        }
    }
}
