using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebUI.ViewComponents.Default
{
    public class _ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
