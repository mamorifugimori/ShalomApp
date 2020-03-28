using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShalomApp.Backend.Startup))]
namespace ShalomApp.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
