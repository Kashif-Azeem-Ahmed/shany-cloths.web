using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shany_cloths.web.Startup))]
namespace Shany_cloths.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
