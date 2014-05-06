using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthExample.Startup))]
namespace AuthExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
