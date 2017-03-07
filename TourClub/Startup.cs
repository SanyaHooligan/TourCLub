using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TourClub.Startup))]
namespace TourClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
