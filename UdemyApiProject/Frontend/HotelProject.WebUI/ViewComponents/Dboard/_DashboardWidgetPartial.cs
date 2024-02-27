using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Staff Count
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/StaffCount");

            //Booking Count
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/BookingCount");

            //AppUser Count
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/AppUserCount");

            //Location Count
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/LocationCount");

            //Room Count
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/RoomCount");

            //Testimonial Count
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/TestimonialCount");

            //Guest Count
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/GuestCount");

            //Contact Count
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client.GetAsync("http://localhost:5248/api/DashboardWidgets/ContactCount");


            if (responseMessage.IsSuccessStatusCode)
            {
                //Staff Count
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.staffCount = jsonData;


                //Booking Count
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.bookingCount = jsonData2;

                //AppUser Count
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.appUserCount = jsonData3;

                //Location Count
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                ViewBag.locationCount = jsonData4;

                //Room Count
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                ViewBag.roomCount = jsonData5;

                //Testimonial Count
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                ViewBag.testimonialCount = jsonData6;

                //Guest Count
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                ViewBag.guestCount = jsonData7;

                //Contact Count
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                ViewBag.contactCount = jsonData8;
            }

            return View();
        }




    }
}
