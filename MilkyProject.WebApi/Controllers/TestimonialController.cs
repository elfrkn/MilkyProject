using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;
using MilkProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok("Başarıyla eklendi.");
        }
        [HttpDelete]

        public IActionResult DeleteService(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdatTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok("başarıyla güncellendi");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }

    }
}
