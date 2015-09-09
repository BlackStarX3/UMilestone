using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UMilestone.Startup))]
namespace UMilestone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
