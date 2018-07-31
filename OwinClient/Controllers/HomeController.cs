using System.Web.Mvc;

namespace OwinClient.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            return View();
        }
    }
}