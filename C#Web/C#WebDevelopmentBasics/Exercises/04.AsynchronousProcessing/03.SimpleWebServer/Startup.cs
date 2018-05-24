using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _03.SimpleWebServer
{
    public class Startup
    {
        public static void Main()
        {
            var address = IPAddress.Parse("127.0.0.1");
            var port = 1300;
            var listener = new TcpListener(address, port);
            listener.Start();

            Console.WriteLine("Server started.");
            Console.WriteLine($"Listenin to TCP clients at 127.0.0.1:{port}");

            var task = Task.Run(() => ConnectWithTcpClient(listener));
            task.Wait();
        }

        private static async Task ConnectWithTcpClient(TcpListener lisener)
        {
            while (true)
            {
                Console.WriteLine("Waiting for client...");
                var client = await lisener.AcceptTcpClientAsync();
               
			   Console.WriteLine("Client connected.");

                var buffer = new byte[1024];
                client.GetStream().Read(buffer, 0, buffer.Length);

                var message = Encoding.ASCII.GetString(buffer);
                Console.WriteLine(message);

                var data = Encoding.ASCII.GetBytes("Hello from server!");
                client.GetStream().Write(data, 0, data.Length);

                Console.WriteLine("Closing connection.");
                client.GetStream().Dispose();
            }
        }
    }
}
