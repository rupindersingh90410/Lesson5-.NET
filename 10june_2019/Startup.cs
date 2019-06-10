using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_10june_2019.Startup))]
namespace _10june_2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
