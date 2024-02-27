using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
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
            MimeMessage mimeMessage = new MimeMessage();
            
            //Kimden
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "mehmetsaidsonmez025@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //Kime
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);


            //Mesaj
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Message;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            client.Authenticate("mehmetsaidsonmez025@gmail.com", "mfmyeoqgziquuuvl");
            client.Send(mimeMessage);
            client.Disconnect(true);

            //Gönderilen mailin veritabanına kaydedilmesi

            return View();
        }
    }
}
