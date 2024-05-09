using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Areas.Admin.ViewComponents
{
    public class _SidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
