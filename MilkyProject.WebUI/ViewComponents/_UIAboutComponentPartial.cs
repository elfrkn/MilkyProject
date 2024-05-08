using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.About;
using MilkyProject.WebUI.DTOs.Adress;
using MilkyProject.WebUI.DTOs.Testimonial;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UIAboutComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UIAboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult>  InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7166/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return View(values.FirstOrDefault());
            }
            return View();
        }
    }
}
