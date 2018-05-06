using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auto_Service.Startup))]
namespace Auto_Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
