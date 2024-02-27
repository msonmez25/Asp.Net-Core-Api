using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.StaffDefaultPage
{
    public class _StaffListDefaultPage : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _StaffListDefaultPage(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5248/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ViewStaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
