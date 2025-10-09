using HotelierAPI_WebUI.DTOs.FollowersDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace HotelierAPI_WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://instagram-scrapper-new.p.rapidapi.com/getUserInfoByUsername?username=_yigitataman"),
                Headers =
    {
        { "x-rapidapi-key", "f3199434e5msh58ee98c4e68e750p14cb70jsn56545f8ecbb0" },
        { "x-rapidapi-host", "instagram-scrapper-new.p.rapidapi.com" },
    },
            };
            using (var response = await client3.SendAsync(request3))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramDTO resultInstagramDTO = JsonConvert.DeserializeObject<ResultInstagramDTO>(body);
                ViewBag.InstagramFollower = resultInstagramDTO.data.follower_count;
                ViewBag.InstagramFollowing = resultInstagramDTO.data.following_count;
            }

            var client4 = new HttpClient();
            var request4 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-x-com-data-scraper.p.rapidapi.com/v2/UserByScreenName/?username=_Atamany"),
                Headers =
    {
        { "x-rapidapi-key", "bc0fdeb878msh2213987e8ca48cbp17bc42jsnb80972c524ff" },
        { "x-rapidapi-host", "real-time-x-com-data-scraper.p.rapidapi.com" },
    },
            };
            using (var response = await client4.SendAsync(request4))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultXDTO resultXDTO = JsonConvert.DeserializeObject<ResultXDTO>(body);
                ViewBag.XFollower = resultXDTO.data.user.result.legacy.followers_count;
                ViewBag.XFollowing = resultXDTO.data.user.result.legacy.friends_count;
            }

            return View();
        }
    }
}
