using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShalomApp.API.Startup))]
namespace ShalomApp.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
