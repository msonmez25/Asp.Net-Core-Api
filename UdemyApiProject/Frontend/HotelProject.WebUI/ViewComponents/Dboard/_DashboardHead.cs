using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Dboard
{
    public class _DashboardHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
