using FDMC.Data;
using SimpleMvc.Framework;
using SimpleMvc.Framework.Routers;

namespace FDMC.App
{
    public class Launcher
    {
        static void Main()
        {
            var server = new WebServer.WebServer(8888, new ControllerRouter(), new ResourceRouter());
            var db = new FDMCContext();

            MvcEngine.Run(server,db);
        }
    }
}
