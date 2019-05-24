using System.Web.Mvc;

namespace MGG.Crud.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public void Alert(string title, string text, string type)
        {
            var alert = $"swal('{title}', '{text}', '{type}');";

            TempData["Notification"] = alert;
        }
    }
}