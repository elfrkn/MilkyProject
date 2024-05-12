using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.DTOs.Newsletter;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UINewsletterComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new CreateGalleryDto());
        }
    }
}
