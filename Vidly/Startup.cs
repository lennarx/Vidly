using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TIdentity.Startup))]
namespace TIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
