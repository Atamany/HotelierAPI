using HotelierAPI_BusinessLayer.Abstract;
using HotelierAPI_DataAccessLayer.Concrete;
using HotelierAPI_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelierAPI_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult GetAppUsersWithWorkLocation()
        {
            Context context = new Context();
            //var values = _appUserService.TGetAppUsersWithWorkLocation();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWithWorkLocationViewModel
            {
                Id = y.Id,
                Name = y.Name,
                Surname = y.Surname,
                City = y.City,
                ImageUrl = y.ImageUrl,
                WorkDepartment = y.WorkDepartment,
                Country = y.Country,
                Gender = y.Gender,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                WorkLocationCity = y.WorkLocation.WorkLocationCity
            }).ToList();
            return Ok(values);
        }
    }
}
