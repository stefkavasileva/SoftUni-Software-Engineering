using System;

public class Startup
{
    public static void Main()
    {
        var builder = new NationsBuilder();
        
        while (true)
        {
            var inputLine = Console.ReadLine();
            builder.CommandInterpreter(inputLine);
            if(inputLine.Equals("Quit"))
                break;
        }
    }
}

