using HotelierAPI_WebUI.DTOs.AboutDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierAPI_WebUI.Controllers
{
    public class AboutAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7135/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7135/api/About/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateAboutDTO>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDTO model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7135/api/About", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}
