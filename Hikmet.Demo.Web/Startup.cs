using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hikmet.Demo.Web.Startup))]
namespace Hikmet.Demo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
