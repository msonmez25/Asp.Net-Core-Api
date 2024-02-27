using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Dboard
{
    public class _AdminNavbarRight :ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;

        public _AdminNavbarRight(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewAppUserDto model = new ViewAppUserDto();
            ViewBag.ImageUrl = values.ImageUrl;
            ViewBag.user = values.Name +" "+ values.Surname;
            return View();
        }

    }
}
