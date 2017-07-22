using System;

public class Startup
{
    public static void Main()
    {
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

        var driverName = Console.ReadLine();
        ICar car = new Ferrari(driverName);
        Console.WriteLine(car);

    }
}

