using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineWebStore.WebUI.Startup))]
namespace OnlineWebStore.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
