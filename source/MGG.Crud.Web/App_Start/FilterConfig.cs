using System.Web.Mvc;
using MBB.Crud.Infra.CrossCutting.MvcFilters;
using SimpleInjector;

namespace MGG.Crud.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, Container container)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(container.GetInstance<GlobalFilter>());
        }
    }
}
