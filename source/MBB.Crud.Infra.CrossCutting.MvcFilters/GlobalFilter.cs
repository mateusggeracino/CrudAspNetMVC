using System.Web.Mvc;

namespace MBB.Crud.Infra.CrossCutting.MvcFilters
{
    public class GlobalFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
            {
                filterContext.Controller.TempData["Error"] = filterContext.Exception.Message;
            }
        }
    }
}