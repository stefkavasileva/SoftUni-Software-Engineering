using HTTPServer.Server.Routing;
using MyFirstWebServer.Server.Contracts;
using MyFirstWebServer.Server.Routing.Contracts;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MyFirstWebServer.Server
{
    public class WebServer : IRunnable
    {
        private readonly int port;

        private readonly IServerRouteConfig serverRouteConfig;

        private readonly TcpListener tcpListener;

        private bool isRunning;

        public WebServer(int port, IAppRouteConfig routeConfig)
        {
            this.port = port;
            this.tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);

            this.serverRouteConfig = new ServerRouteConfig(routeConfig);
        }

        public void Run()
        {
            this.tcpListener.Start();
            this.isRunning = true;

            Console.WriteLine($"Server started. Listening to TCP clients at 127.0.0.1:{port}");

            var task = Task.Run(this.ListenLoop);
            task.Wait();
        }

        private async Task ListenLoop()
        {
            while (this.isRunning)
            {
                var client = await this.tcpListener.AcceptSocketAsync();
                var connectionHandler = new ConnectionHandler(client, this.serverRouteConfig);
                var connection = connectionHandler.ProcessRequestAsync();
                connection.Wait();
            }
        }
    }
}
