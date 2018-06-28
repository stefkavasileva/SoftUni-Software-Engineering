using MeTube.Data;

namespace MeTube.App
{
    using WebServer;
    using SimpleMvc.Framework;
    using SimpleMvc.Framework.Routers;

    public class Launcher
    {
        public static void Main()
        {
            //not finish yet
            var server = new WebServer(8888, new ControllerRouter(), new ResourceRouter());
            var db = new MeTubeContext();

            MvcEngine.Run(server, db);
        }
    }
}
