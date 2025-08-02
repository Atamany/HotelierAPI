using HotelierAPI_BusinessLayer.Abstract;
using HotelierAPI_EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactAPIController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactAPIController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _contactService.TInsert(contact);
            return Ok();
        }
    }
}
