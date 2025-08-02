using HotelierAPI_WebUI.DTOs.ContactDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelierAPI_WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddContact()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddContact(CreateContactDTO createContactDTO)
        {
            createContactDTO.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDTO);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7135/api/ContactAPI", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
