using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mysterio.Startup))]
namespace Mysterio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
