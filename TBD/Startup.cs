using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TBD.Startup))]
namespace TBD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
