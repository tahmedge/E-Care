using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Care.Startup))]
namespace E_Care
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
