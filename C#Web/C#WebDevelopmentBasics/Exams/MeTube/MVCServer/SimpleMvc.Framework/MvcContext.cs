namespace SimpleMvc.Framework
{
    public class MvcContext
    {
        private static MvcContext instance;
        private static readonly object instanceLock = new object();
        private MvcContext()
        {
            // This is going to be a singleton
        }

        public static MvcContext Get
        {
            get
            {
                if (instance == null)
                {
                    // This achieves thread safety
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new MvcContext();
                        }
                    }
                }

                return instance;
            }
        }

        public string ControllerSuffix { get; set; }

        public string AssemblyName { get; set; }

        public string ControllersFolder { get; set; }

        public string ModelsFolder { get; set; }

        public string ViewsFolder { get; set; }
    }
}
