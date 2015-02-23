using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RomeoTracker.Startup))]
namespace RomeoTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
