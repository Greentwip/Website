using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Greentwip.Startup))]
namespace Greentwip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
