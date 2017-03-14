using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EOHPractical.Startup))]
namespace EOHPractical
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
