using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public PartialViewResult _AdminLayoutHead()
        {
            return PartialView();
        }
        public PartialViewResult _AdminLayoutPreLoader()
        {
            return PartialView();
        }
        public PartialViewResult _AdminLayoutNavHeader()
        {
            return PartialView();
        }
        public PartialViewResult _AdminLayoutHeader()
        {
            return PartialView();
        }
        public PartialViewResult _AdminLayoutSidebar()
        {
            return PartialView();
        }
        public PartialViewResult _AdminLayoutFooter()
        {
            return PartialView();
        }
        public PartialViewResult _AdminLayoutScript()
        {
            return PartialView();
        }
    }
}
