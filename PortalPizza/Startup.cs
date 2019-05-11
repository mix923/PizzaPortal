using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalPizza.Startup))]
namespace PortalPizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
