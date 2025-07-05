using HotelierAPI_WebUI.DTOs.ServiceDTO;
using HotelierAPI_WebUI.DTOs.SubscribeDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierAPI_WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult NewsletterPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> NewsletterPartial(CreateSubscribeDTO createSubscribeDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDTO);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7135/api/Subscribe", stringContent);
            return RedirectToAction("Index","Default");
        }
    }
}
