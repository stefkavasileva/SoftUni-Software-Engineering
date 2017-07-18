using System;

public class Startup
{
    public static void Main()
    {
        var manager = new DraftManager();
        while (true)
        {
            var inputLine = Console.ReadLine();
            manager.CommandInterpreter(inputLine);
            if (inputLine.Equals("Shutdown")) break;
        }

    }
}
