using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClearProject.Startup))]
namespace ClearProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
