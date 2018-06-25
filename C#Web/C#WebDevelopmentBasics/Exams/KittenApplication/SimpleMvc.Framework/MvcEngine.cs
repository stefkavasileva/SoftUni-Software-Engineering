namespace SimpleMvc.Framework
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Reflection;
    using WebServer;

    public static class MvcEngine
    {
        public static void Run(WebServer server, DbContext dbContext)
        {
            ConfigureMvcContext(MvcContext.Get);
            ConfigureDatabaseContext(dbContext);

            while (true)
            {
                try
                {
                    server.Run();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void ConfigureMvcContext(MvcContext context)
        {
           context.AssemblyName = Assembly.GetEntryAssembly().GetName().Name;
           context.ControllersFolder = "Controllers";
           context.ControllerSuffix = "Controller";
           context.ModelsFolder = "Models";
           context.ViewsFolder = "Views";
        }

        public static void ConfigureDatabaseContext(DbContext context)
        {
            using (context)
            {
                context.Database.Migrate();
            }
        }
    }
}