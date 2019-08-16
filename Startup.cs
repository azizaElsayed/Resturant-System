using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestPro.Startup))]
namespace RestPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
