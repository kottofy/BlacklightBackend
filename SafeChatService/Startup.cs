using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SafeChatService.Startup))]

namespace SafeChatService
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