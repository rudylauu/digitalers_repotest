using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(seguridad_con_ASP.net.Startup))]
namespace seguridad_con_ASP.net
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
