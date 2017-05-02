using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEcommerceSite.Startup))]
namespace MyEcommerceSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
