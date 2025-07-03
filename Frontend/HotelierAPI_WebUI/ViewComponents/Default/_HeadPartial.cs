using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
