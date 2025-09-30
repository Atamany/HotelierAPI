using HotelierAPI_BusinessLayer.Abstract;
using HotelierAPI_EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierAPI_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageService.TGetList().OrderByDescending(x=>x.Date);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.TInsert(sendMessage);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.TUpdate(sendMessage);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageService.TGetById(id);
            _sendMessageService.TDelete(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _sendMessageService.TGetById(id);
            return Ok(values);
        }
    }
}

