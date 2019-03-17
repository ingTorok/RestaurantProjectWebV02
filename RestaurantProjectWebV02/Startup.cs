using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantProjectWebV02.Startup))]
namespace RestaurantProjectWebV02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
