using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;
using MilkProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _socialMediaService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TInsert(socialMedia);
            return Ok("başarıyla eklendi.");
        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("başarıyla silindi");
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult PutSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TUpdate(socialMedia);
            return Ok("başarıyla güncellendi.");

        }
    }
}
