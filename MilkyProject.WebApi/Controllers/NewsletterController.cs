using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;
using MilkProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsletterController : ControllerBase
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpGet]
        public IActionResult EmployerList()
        {
            var values = _newsletterService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateNewsletter(Newsletter newsletter)
        {
            _newsletterService.TInsert(newsletter);
            return Ok("Başarıyla eklendi.");
        }
    }
}
