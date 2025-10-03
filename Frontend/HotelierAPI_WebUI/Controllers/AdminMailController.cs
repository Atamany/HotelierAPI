using HotelierAPI_WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelierAPI_WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAPI", "atamanyprojedenemeleri@gmail.com");
            message.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            message.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            message.Body = bodyBuilder.ToMessageBody();

            message.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("atamanyprojedenemeleri@gmail.com", "txbd xqjm xxhi dvfv");
            client.Send(message);
            client.Disconnect(true);

            return RedirectToAction("Index", "AdminMail");

        }
    }
}
