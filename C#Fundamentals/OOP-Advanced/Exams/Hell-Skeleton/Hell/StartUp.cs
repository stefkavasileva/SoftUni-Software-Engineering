public class StartUp
{
    public static void Main()
    {
        IInputReader reader = new ConsoleReader();
        IOutputWriter writer = new ConsoleWriter();
        IManager manager = new HeroManager();

        Engine engine = new Engine(reader, writer, manager);
        engine.Run();
    }
}