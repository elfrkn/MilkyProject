﻿using Microsoft.AspNetCore.Http;
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
        public IActionResult NewsletterList()
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
        [HttpDelete]

        public IActionResult DeleteNewsletter(int id)
        {
            _newsletterService.TDelete(id);
            return Ok("başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateNewsletter(Newsletter newsletter)
        {
            _newsletterService.TUpdate(newsletter);
            return Ok("başarıyla güncellendi");
        }
        [HttpGet("GetNewsletter")]
        public IActionResult GetNewsletter(int id)
        {
            var value = _newsletterService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("GetNewsletterCount")]
        public IActionResult GetNewsletterCount()
        {
            return Ok(_newsletterService.TGetNewsletterCount());
        }
    }
}
