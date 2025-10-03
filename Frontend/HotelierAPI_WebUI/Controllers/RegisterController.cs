using HotelierAPI_EntityLayer.Concrete;
using HotelierAPI_WebUI.DTOs.RegisterDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDTO createNewUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser
            {
                Name = createNewUserDTO.Name,
                Surname = createNewUserDTO.Surname,
                UserName = createNewUserDTO.Username,
                Email = createNewUserDTO.Mail
            };
            var result = await _userManager.CreateAsync(appUser, createNewUserDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }
    }
}
