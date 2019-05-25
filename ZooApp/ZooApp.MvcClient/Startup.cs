using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZooApp.MvcClient.Startup))]
namespace ZooApp.MvcClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
