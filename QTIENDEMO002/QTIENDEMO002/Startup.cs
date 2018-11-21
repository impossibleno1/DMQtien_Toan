using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QTIENDEMO002.Startup))]
namespace QTIENDEMO002
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
