using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UIAboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
