using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Administrate.Startup))]
namespace Administrate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
