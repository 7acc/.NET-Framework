using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Föreläsning_1_asp_web_forms.Startup))]
namespace Föreläsning_1_asp_web_forms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
