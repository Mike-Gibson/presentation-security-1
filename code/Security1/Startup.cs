using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Security1.Startup))]
namespace Security1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
