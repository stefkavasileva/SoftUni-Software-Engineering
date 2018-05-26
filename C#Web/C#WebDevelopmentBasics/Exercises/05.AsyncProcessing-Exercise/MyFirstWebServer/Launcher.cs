using MyFirstWebServer.Application;
using MyFirstWebServer.Server;
using MyFirstWebServer.Server.Contracts;
using MyFirstWebServer.Server.Routing;
using MyFirstWebServer.Server.Routing.Contracts;


namespace MyFirstWebServer
{
    public class Launcher : IRunnable
    {
        private WebServer webServer;

        public static void Main()
        {
            new Launcher().Run();
        }

        public void Run()
        {
            IApplication app = new MainApplication();           
            IAppRouteConfig routeConfig = new AppRouteConfig();
            app.Start(routeConfig);

            this.webServer = new WebServer(8230, routeConfig);
            this.webServer.Run();
        }
    }
}
