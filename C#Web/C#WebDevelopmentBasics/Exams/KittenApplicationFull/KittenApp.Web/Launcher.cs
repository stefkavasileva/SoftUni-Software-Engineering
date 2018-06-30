namespace KittenApp.Web
{
    using KittenApp.Data;
    using SimpleMvc.Framework;
    using SimpleMvc.Framework.Routers;
    using WebServer;

    public class Launcher
    {
        public static void Main()
        {
            var context = new KittenAppContext();

            var server = new WebServer(
                42420,
                new ControllerRouter(),
                new ResourceRouter());
            MvcEngine.Run(server, new KittenAppContext());
        }
    }
}
