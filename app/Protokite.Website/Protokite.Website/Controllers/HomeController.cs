using System.Web.Mvc;

namespace Protokite.Website.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(bool emailSent = false)
        {
            ViewBag.EmailSent = emailSent;

            return View();
        }
    }
}