using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FauxPinterest.Startup))]
namespace FauxPinterest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
