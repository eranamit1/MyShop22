using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySop.WebUI.Startup))]
namespace MySop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
