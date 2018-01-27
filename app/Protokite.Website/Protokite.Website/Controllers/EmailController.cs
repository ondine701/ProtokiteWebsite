using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace Protokite.Website.Controllers
{
    public class EmailController : Controller
    {
        private MailAddress _fromAddress;
        private MailAddress _adminAddress;
        private SmtpClient _smtpClient;

        public EmailController()
        {
            _fromAddress = new MailAddress("squarepantsivan@gmail.com");
            _adminAddress = new MailAddress("squarepantsivan@gmail.com");

            _smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_fromAddress.Address, "exit_sucess(1);")
            };

        }

        [HttpPost]
        public ActionResult Index(string name, string email, string content)
        {
            string body = "<h3>" + name + " (" + email + ")" + "</h3>" + "<h4>" + content + "</h4>";

            using (var message = new MailMessage(_fromAddress, _adminAddress)
            {
                Subject = "Protokite website contact",
                Body = body,
                IsBodyHtml = true
            })
            {
                _smtpClient.Send(message);
            }
            
            return RedirectToAction("Index", "Home", new {  emailSent = true });
        }
    }
}