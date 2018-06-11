namespace GameStore.App
{
    using SimpleMvc.Framework.Routers;
    using WebServer;

    public class Launcher
    {
        public static void Main()
        {
            var server = new WebServer(8888, new ControllerRouter(), new ResourceRouter());
            server.Run();
        }
    }
}
