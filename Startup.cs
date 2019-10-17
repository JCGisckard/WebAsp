using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web1.Startup))]
namespace web1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
