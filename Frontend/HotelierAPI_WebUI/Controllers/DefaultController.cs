using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
