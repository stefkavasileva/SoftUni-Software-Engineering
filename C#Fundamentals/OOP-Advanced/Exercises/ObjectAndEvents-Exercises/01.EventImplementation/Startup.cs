using System;

class Startup
{
    static void Main()
    {
        var dispatcher = new Dispatcher();
        var handler = new Handler();
        dispatcher.NameChange += handler.OnDispatcherNameChange;

        var name = Console.ReadLine();

        while (!name.Equals("End"))
        {
            dispatcher.Name = name;
            name = Console.ReadLine();
        }
    }
}
