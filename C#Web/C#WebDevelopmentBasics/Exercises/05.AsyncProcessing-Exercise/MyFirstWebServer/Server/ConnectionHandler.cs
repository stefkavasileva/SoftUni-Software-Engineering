using MyFirstWebServer.Server.Handlers;
using MyFirstWebServer.Server.HTTP;
using MyFirstWebServer.Server.Routing.Contracts;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebServer.Server
{
    public class ConnectionHandler
    {
        private readonly Socket client;

        private readonly IServerRouteConfig serverRouteConfig;

        public ConnectionHandler(Socket client, IServerRouteConfig serverRouteConfig)
        {
            this.client = client;
            this.serverRouteConfig = serverRouteConfig;
        }

        public async Task ProcessRequestAsync()
        {
            var request = await this.ReadRequest();
            var httpContext = new HttpContext(request);
            var response = new HttpHandler(this.serverRouteConfig).Handle(httpContext);
            var toBytes = new ArraySegment<byte>(Encoding.ASCII.GetBytes(response.Response));

            await this.client.SendAsync(toBytes, SocketFlags.None);

            Console.WriteLine(request);
            Console.WriteLine(response.Response);
        }

        private async Task<string> ReadRequest()
        {
            var request = string.Empty;
            var data = new ArraySegment<byte>(new byte[1024]);

            int numBytesRead;
            while ((numBytesRead = await this.client.ReceiveAsync(data, SocketFlags.None)) > 0)
            {
                request += Encoding.ASCII.GetString(data.Array, 0, numBytesRead);
                if (numBytesRead < 1024) break;
            }

            return request;
        }
    }
}
