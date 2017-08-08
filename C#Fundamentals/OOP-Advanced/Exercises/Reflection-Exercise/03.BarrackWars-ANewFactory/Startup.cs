public class Startup
{
    public static void Main()
    {
        IRepository repository = new UnitRepository();
        IUnitFactory unitFactory = new UnitFactory();
        IRunnable engine = new Engine(repository, unitFactory);
        engine.Run();
    }
}

