using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rheal_MVP_App.Startup))]
namespace Rheal_MVP_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
