using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Dsuarez_SyncView.Startup))]

namespace Dsuarez_SyncView
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }

    }
}