using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    public class Startup
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoType, cargoWeight);
                var tires = new Tire[4];
                var counter = 0;
                for (int j = 0; j < 8; j += 2)
                {
                    var tirePressure = double.Parse(carInfo[5 + j]);
                    var tireAge = int.Parse(carInfo[6 + j]);
                    var currentTire = new Tire(tirePressure, tireAge);
                    tires[counter] = currentTire;
                    counter++;
                }

                var car = new Car(model, engine, cargo);
                car.Tires = tires;
                cars.Add(car);
            }

            var result = new List<Car>();

            var cargotype = Console.ReadLine();
            if (cargotype.Equals("fragile"))
            {
                result = cars.Where(c => c.Cargo.Type.Equals("fragile") && c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                result = cars.Where(c => c.Cargo.Type.Equals("flamable") && c.Engine.Power > 250).ToList();
            }

            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
