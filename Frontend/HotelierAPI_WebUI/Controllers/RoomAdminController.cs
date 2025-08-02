using HotelierAPI_WebUI.DTOs.RoomDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierAPI_WebUI.Controllers
{
    public class RoomAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RoomAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7135/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(CreateRoomDTO model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7135/api/Room", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7135/api/Room?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7135/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateRoomDTO>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDTO model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7135/api/Room", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}
