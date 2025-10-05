using HotelierAPI_WebUI.DTOs.ContactDTO;
using HotelierAPI_WebUI.DTOs.MessageCategoryDTO;
using HotelierAPI_WebUI.DTOs.RoomDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelierAPI_WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7135/api/MessageCategory");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDTO>>(jsonData);

            List<SelectListItem> selectList = (from x in values
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.MessageCategoryID.ToString()
                                               }).ToList();
            ViewBag.v = selectList;

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
