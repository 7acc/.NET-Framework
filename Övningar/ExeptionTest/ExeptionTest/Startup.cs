using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExeptionTest.Startup))]
namespace ExeptionTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
