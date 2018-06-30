using SimpleMvc.Framework;
using SimpleMvc.Framework.Routers;
using TicketSystem.Data;

namespace TicketSystem.App
{
    public class Launcher
    {
        public static void Main()
        {
            var server = new WebServer.WebServer(8888, new ControllerRouter(), new ResourceRouter());
            var db = new TicketSystemContext();

            MvcEngine.Run(server, db);
        }
    }
}
