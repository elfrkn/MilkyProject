using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UIGalleryComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
