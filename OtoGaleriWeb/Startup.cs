using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OtoGaleriWeb.Startup))]
namespace OtoGaleriWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
