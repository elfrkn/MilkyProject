using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerService _employerService;

        public EmployerController(IEmployerService employerService)
        {
            _employerService = employerService;
        }

        [HttpGet]
        public IActionResult EmployerList()
        {
            var values = _employerService.TGetListAll();
            return Ok(values);
        }
    }
}
