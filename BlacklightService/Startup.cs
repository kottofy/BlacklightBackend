using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BlacklightService.Startup))]

namespace BlacklightService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
            app.MapSignalR();
        }
    }
}