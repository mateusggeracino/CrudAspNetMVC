using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MGG.Crud.Web.Startup))]
namespace MGG.Crud.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
