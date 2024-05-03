using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UISliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
