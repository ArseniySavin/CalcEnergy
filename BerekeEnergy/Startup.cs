using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BerekeEnergy.Startup))]
namespace BerekeEnergy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
