using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWhale.Startup))]
namespace ProjectWhale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
