using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var vehicles = new List<Vehicle>();

        var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var carFuelQuantity = double.Parse(carInfo[1]);
        var carLitersPerKm = double.Parse(carInfo[2]);
        var carCapacity = double.Parse(carInfo[3]);

        var car = new Car(carFuelQuantity, carLitersPerKm, carCapacity);

        var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var truckFuelQuantity = double.Parse(truckInfo[1]);
        var truckLitersPerKm = double.Parse(truckInfo[2]);
        var truckCapacity = double.Parse(truckInfo[3]);

        var truck = new Truck(truckFuelQuantity, truckLitersPerKm, truckCapacity);

        var busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var busFuelQuantity = double.Parse(busInfo[1]);
        var busLitersPerKm = double.Parse(busInfo[2]);
        var busCapacity = double.Parse(busInfo[3]);

        var bus = new Bus(busFuelQuantity, busLitersPerKm, busCapacity);

        var numbersOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbersOfLines; i++)
        {
            try
            {
                var comandTokens = Console.ReadLine().Split();
                var type = comandTokens[1];

                if (type.Equals("Car"))
                {
                    ExecuteAction(car, comandTokens[0], double.Parse(comandTokens[2]));
                }
                else if (type.Equals("Truck"))
                {
                    ExecuteAction(truck, comandTokens[0], double.Parse(comandTokens[2]));
                }
                else if (type.Equals("Bus"))
                {
                    ExecuteAction(bus, comandTokens[0], double.Parse(comandTokens[2]));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static void ExecuteAction(Vehicle vehicle, string comand, double param)
    {
        if (comand.Equals("Drive"))
        {
            Console.WriteLine(vehicle.TryDrive(param));
            return;
        }
        else if (comand.Equals("DriveEmpty"))
        {
            Console.WriteLine(vehicle.TryDrive(param, false));
            return;
        }

        vehicle.Reflue(param);
    }
}

