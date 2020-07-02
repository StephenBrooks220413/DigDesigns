using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigWebForms.Startup))]
namespace DigWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
