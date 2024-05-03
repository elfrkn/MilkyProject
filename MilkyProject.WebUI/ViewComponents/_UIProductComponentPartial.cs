using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UIProductComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
