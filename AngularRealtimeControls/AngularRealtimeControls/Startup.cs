using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AngularRealtimeControls.Startup))]

namespace AngularRealtimeControls
{
    public class Startup
    {
        BackgroundTicker _backgroundTicker;

        public void Configuration(IAppBuilder app)
        {

            _backgroundTicker = new BackgroundTicker();
            app.MapSignalR();
        }
    }
}
