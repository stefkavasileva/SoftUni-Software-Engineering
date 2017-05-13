using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SpeedRacing
{ 
    public class SpeedRacing
    {
        public static void Main()
        {
            var cars = new List<Car>();

            var carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                var carInfor = Console.ReadLine().Split();
                var model = carInfor[0];
                var fuel = decimal.Parse(carInfor[1]);
                var fuelCost = decimal.Parse(carInfor[2]);

                cars.Add(new Car(model, fuel, fuelCost));
            }

            var comandDrive = Console.ReadLine();
            while (!comandDrive.Equals("End"))
            {
                var comandArgs = comandDrive.Split();
                var model = comandArgs[1];
                var distance = decimal.Parse(comandArgs[2]);

                var currentCar = cars.FirstOrDefault(c => c.Model == model);

                if (!Car.CanDrive(currentCar,distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            
                comandDrive = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {(int)car.TraveledDistance}");  
            }
        }  
    }
}
