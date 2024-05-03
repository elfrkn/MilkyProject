using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UICoprightComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
