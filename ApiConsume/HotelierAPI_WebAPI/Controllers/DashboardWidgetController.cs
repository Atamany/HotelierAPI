using HotelierAPI_BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;

        public DashboardWidgetController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService = roomService;
        }
        [HttpGet("GetStaffCount")]
        public IActionResult GetStaffCount()
        {
            var staffCount = _staffService.TGetStaffCount();
            return Ok(staffCount);
        }
        [HttpGet("GetBookingCount")]
        public IActionResult GetBookingCount()
        {
            var bookingCount = _bookingService.TGetBookingCount();
            return Ok(bookingCount);
        }
        [HttpGet("GetAppUserCount")]
        public IActionResult GetAppUserCount()
        {
            var appUserCount = _appUserService.TGetAppUserCount();
            return Ok(appUserCount);
        }
        [HttpGet("GetRoomCount")]
        public IActionResult GetRoomCount()
        {
            var roomCount = _roomService.TGetRoomCount();
            return Ok(roomCount);
        }
    }
}
