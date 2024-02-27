using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Dboard
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
