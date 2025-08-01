using HotelierAPI_BusinessLayer.Abstract;
using HotelierAPI_EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingAPIController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingAPIController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking([FromBody] Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
        [HttpPut("BookingApproved")]
        public IActionResult BookingApproved(int id)
        {
            Booking booking = _bookingService.TGetById(id);
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("BookingRejected")]
        public IActionResult BookingRejected(int id)
        {
            Booking booking = _bookingService.TGetById(id);
            _bookingService.TBookingStatusChangeRejected(booking);
            return Ok();
        }
    }
}
