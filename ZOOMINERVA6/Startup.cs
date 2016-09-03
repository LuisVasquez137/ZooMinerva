using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZOOMINERVA6.Startup))]
namespace ZOOMINERVA6
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
