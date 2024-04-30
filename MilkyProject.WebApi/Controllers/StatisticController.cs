using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public StatisticController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]

        public IActionResult CategoryCount()
        {
            return Ok(_categoryService.TGetCategoryCount());
        }

    }
}
