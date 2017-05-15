using System;
using System.Linq;

namespace _08.Car
{
    public class StartUp
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var car = new Car(tokens[0], tokens[1], tokens[2]);

            var command = Console.ReadLine();
            while (command != "END")
            {
                var comandArgs = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                switch (comandArgs[0])
                {
                    case "Travel": car.Travel(double.Parse(comandArgs[1])); break;
                    case "Refuel": car.Refuel(double.Parse(comandArgs[1])); break;
                    case "Distance": car.Distance(); break;
                    case "Time": car.Time(); break;
                    case "Fuel": car.GetFuel(); break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
