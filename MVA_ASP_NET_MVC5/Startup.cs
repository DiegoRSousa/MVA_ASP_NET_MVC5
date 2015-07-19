using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVA_ASP_NET_MVC5.Startup))]
namespace MVA_ASP_NET_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
