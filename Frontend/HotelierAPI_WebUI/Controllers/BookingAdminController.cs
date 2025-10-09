using HotelierAPI_EntityLayer.Concrete;
using HotelierAPI_WebUI.DTOs.BookingDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierAPI_WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7135/api/BookingAPI");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddBooking()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDTO model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7135/api/BookingAPI", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7135/api/BookingAPI?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7135/api/BookingAPI/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateBookingDTO>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDTO model)
        {
            if (model.Description == null) { model.Description = " "; }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7135/api/BookingAPI/UpdateBooking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookingApproved(int BookingID)
        {
            var bookingApprovedDTO = new BookingApprovedDTO { BookingID = BookingID };
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(bookingApprovedDTO);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7135/api/BookingAPI/BookingApproved?id={BookingID}", stringContent);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookingRejected(int BookingID)
        {
            var bookingRejectedDTO = new BookingRejectedDTO { BookingID = BookingID };
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(bookingRejectedDTO);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7135/api/BookingAPI/BookingRejected?id={BookingID}", stringContent);
            return RedirectToAction("Index");
        }

    }
}
