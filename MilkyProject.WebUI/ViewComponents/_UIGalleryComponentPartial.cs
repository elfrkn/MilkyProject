using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.Employer;
using MilkyProject.WebUI.DTOs.Gallery;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UIGalleryComponentPartial : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _UIGalleryComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7166/api/Gallery");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGalleryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
    
}
