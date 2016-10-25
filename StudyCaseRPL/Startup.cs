using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyCaseRPL.Startup))]
namespace StudyCaseRPL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
