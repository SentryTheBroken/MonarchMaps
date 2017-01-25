using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VivianTest1.Startup))]
namespace VivianTest1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
