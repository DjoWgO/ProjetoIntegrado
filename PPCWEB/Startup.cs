using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPCWEB.Startup))]
namespace PPCWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
