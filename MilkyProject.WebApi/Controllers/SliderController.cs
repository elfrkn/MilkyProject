using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;
using MilkProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet]
        public IActionResult SliderList()
        {
            var values = _sliderService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateSlider(Slider slider)
        {
            _sliderService.TInsert(slider);
            return Ok("Ürün başarıyla eklendi.");
        }

        [HttpDelete]
        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return Ok("Ürün başarıyla silindi");
        }

        [HttpGet("GetSlider")]
        public IActionResult GetSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult PutSlider(Slider slider)
        {
            _sliderService.TUpdate(slider);
            return Ok("Ürün başarıyla güncellendi.");

        }
    }
}
