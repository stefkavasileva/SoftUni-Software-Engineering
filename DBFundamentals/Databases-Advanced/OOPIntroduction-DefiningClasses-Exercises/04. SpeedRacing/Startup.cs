using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var carsCount = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < carsCount; i++)
        {
            var currentLineArgs = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries);
            var fuelAmount = double.Parse(currentLineArgs[1]);
            var fuelConsum = double.Parse(currentLineArgs[2]);
            cars.Add(new Car(currentLineArgs[0],fuelAmount,fuelConsum));
        }

        var line = Console.ReadLine();
        while (!line.Equals("End"))
        {
            var lineArgs = line.Split();
            var model = lineArgs[1];
            var km = double.Parse(lineArgs[2]);
            var currentCar = cars.FirstOrDefault(x=>x.Model == model);

            if (!Car.CanDrive(currentCar, km))
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            line = Console.ReadLine();
        }

        cars.ForEach(c=>Console.WriteLine(c));
    }
}

