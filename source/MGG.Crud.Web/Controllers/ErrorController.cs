using System.Web.Mvc;

namespace MGG.Crud.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int? code)
        {
            return View("Error");
        }

        public ActionResult AccessDenied()
        {
            return View("Error403");
        }

        public ActionResult InternalServerError()
        {
            return View("Error");
        }
    }
}