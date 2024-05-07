using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.About;
using MilkyProject.WebUI.DTOs.Employer;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UIEmployerComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UIEmployerComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7166/api/Employer");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultEmployerDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
