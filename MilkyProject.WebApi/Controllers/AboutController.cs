using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;
using MilkProject.EntityLayer.Concrete;


namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateCategory(About about)
        {
            _aboutService.TInsert(about);
            return Ok("başarıyla eklendi.");
        }

        [HttpDelete]

        public IActionResult DeleteCategory(int id)
        {
            _aboutService.TDelete(id);
            return Ok("başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateCategory(About about)
        {
            _aboutService.TUpdate(about);
            return Ok("başarıyla güncellendi");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}