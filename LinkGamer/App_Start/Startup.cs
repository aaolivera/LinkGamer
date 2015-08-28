using LinkGamer.App_Start;
using LinkGamer.ServicioHub;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR.Infrastructure;
using Microsoft.Owin;
using Ninject;
using Owin;
using Servicios;
using Servicios.Impl;

[assembly: OwinStartup(typeof(Startup))]
namespace LinkGamer.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}