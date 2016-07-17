using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WepApp.Startup))]
namespace WepApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
