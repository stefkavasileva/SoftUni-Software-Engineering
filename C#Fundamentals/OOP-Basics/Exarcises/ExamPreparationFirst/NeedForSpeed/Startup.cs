using System;

public class Startup
{
    public static void Main()
    {
        var carManager = new CarManager();

        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("Cops Are Here"))
        {
            try
            {
                carManager.CommandInterpreter(inputLine);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            inputLine = Console.ReadLine();
        }
    }
}

