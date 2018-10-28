using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullStackApplication.Startup))]
namespace FullStackApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
