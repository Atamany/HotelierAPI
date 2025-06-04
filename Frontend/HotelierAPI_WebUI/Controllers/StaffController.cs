using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
