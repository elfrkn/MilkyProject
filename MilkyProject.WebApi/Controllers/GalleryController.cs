using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        [HttpGet]
        public IActionResult GalleryList()
        {
            var values = _galleryService.TGetListAll();
            return Ok(values);
        }

    }
}
