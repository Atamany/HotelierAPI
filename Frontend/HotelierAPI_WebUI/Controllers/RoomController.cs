using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
