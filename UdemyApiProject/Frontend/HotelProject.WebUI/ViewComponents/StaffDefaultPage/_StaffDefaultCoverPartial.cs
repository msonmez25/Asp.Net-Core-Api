using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.StaffDefaultPage
{
    public class _StaffDefaultCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
