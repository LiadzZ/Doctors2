using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication3Forum.Startup))]
namespace WebApplication3Forum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
