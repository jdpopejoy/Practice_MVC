using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Application_MVC.Startup))]
namespace Web_Application_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
