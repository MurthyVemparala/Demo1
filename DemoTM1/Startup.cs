using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoTM1.Startup))]
namespace DemoTM1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
