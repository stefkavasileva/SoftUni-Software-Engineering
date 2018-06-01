using HTTPServer.Application;
using HTTPServer.Server;
using HTTPServer.Server.Contracts;
using HTTPServer.Server.Routing;

namespace HTTPServer
{
    class Launcher
    {
        static void Main(string[] args)
        {
            Run(args);
        }

        static void Run(string[] args)
        {

            IApplication app = new MainApplication();
            var appRouteConfig = new AppRouteConfig();

            app.Configure(appRouteConfig);

            var server = new WebServer(8000, appRouteConfig);

            server.Run();
        }
    }
}
