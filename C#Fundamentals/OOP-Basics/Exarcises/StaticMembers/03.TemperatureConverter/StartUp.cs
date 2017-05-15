using System;

namespace _03.TemperatureConverter
{   
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("End"))
            {
                var tokens = inputLine.Split();
                var value = double.Parse(tokens[0]);
                var type = tokens[1];

                if (type.Equals("Celsius"))
                {
                    Console.WriteLine($"{TemperatureConverter.FromCelsiusToFahrenheit(value):f2} Fahrenheit");
                }
                else
                {
                    Console.WriteLine($"{TemperatureConverter.FromFahrenheitToCelsius(value):f2} Celsius");
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
