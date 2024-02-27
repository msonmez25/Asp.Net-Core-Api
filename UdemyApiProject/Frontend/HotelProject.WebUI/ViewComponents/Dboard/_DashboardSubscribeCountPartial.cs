using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace HotelProject.WebUI.ViewComponents.Dboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://instagram-scraper-20231.p.rapidapi.com/userinfo/saidsonmez25"),
    //            Headers =
    //{
    //                //{ "X-RapidAPI-Key", "a0e5b25e3bmsh94b0f760d1818e4p1643b8jsnb755f2c481a0" },
    //    { "X-RapidAPI-Key", "8556311dc3msh67a8006bbf27d6ap199680jsn641b9cbcbeb9" },
    //    { "X-RapidAPI-Host", "instagram-scraper-20231.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //            var values = JsonConvert.DeserializeObject<ViewInstagramDto>(body);
    //            ViewBag.takipEttigim = values.data.edge_follow.count;
    //            ViewBag.takipcilerim = values.data.edge_followed_by.count;
    //        }



    //        var client2 = new HttpClient();
    //        var request2 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=msaidsonmez"),
    //            Headers =
    //        {
    //            //{ "X-RapidAPI-Key", "a0e5b25e3bmsh94b0f760d1818e4p1643b8jsnb755f2c481a0" },
    //            {"X-RapidAPI-Key", "8556311dc3msh67a8006bbf27d6ap199680jsn641b9cbcbeb9"},
    //            { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    //        },
    //        };
    //        using (var response2 = await client2.SendAsync(request2))
    //        {
    //            response2.EnsureSuccessStatusCode();
    //            var body2 = await response2.Content.ReadAsStringAsync();
    //            ViewTwitterDto values2 = JsonConvert.DeserializeObject<ViewTwitterDto>(body2);
    //            ViewBag.TwitterTakipEttiklerim = values2.data.user_info.followers_count;
    //            ViewBag.TwitterTakipcilerim = values2.data.user_info.friends_count;
    //        }




    //        var client3 = new HttpClient();
    //        var request3 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmehmet-sait-s%25C3%25B6nmez-ab02011aa%2F&include_skills=false"),
    //            Headers =
    //        {
    //            //{ "X-RapidAPI-Key", "a0e5b25e3bmsh94b0f760d1818e4p1643b8jsnb755f2c481a0" },
    //            {"X-RapidAPI-Key", "8556311dc3msh67a8006bbf27d6ap199680jsn641b9cbcbeb9"},
    //            { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    //        },
    //        };
    //        using (var response3 = await client3.SendAsync(request3))
    //        {
    //            response3.EnsureSuccessStatusCode();
    //            var body3 = await response3.Content.ReadAsStringAsync();
    //            ViewLinkedinDto values3 = JsonConvert.DeserializeObject<ViewLinkedinDto>(body3);
    //            ViewBag.LinkedinTakipcilerim = values3.data.followers_count;
    //            ViewBag.LinkedinBaglantilarim = values3.data.connections_count;
    //        }





            return View();
        }
    }
}
