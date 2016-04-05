using System.Web.Mvc;

namespace LocalStorage.Controllers
{
    public class StepsController : Controller
    {
        public ActionResult Index()
        {
            return Step1();
        }
        public ActionResult Step1()
        {
            return View();
        }
        public ActionResult Step2()
        {
            return View();
        }
        public ActionResult Step3()
        {
            return View();
        }
        
    }
}
