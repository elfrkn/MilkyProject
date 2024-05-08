using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController : ControllerBase
    {
        private readonly IAdressService _adressService;

        public AdressController(IAdressService adressService)
        {
            _adressService = adressService;
        }

        [HttpGet]
        public IActionResult AdressList()
        {
            var values = _adressService.TGetListAll();
            return Ok(values);
        }

    }
}
