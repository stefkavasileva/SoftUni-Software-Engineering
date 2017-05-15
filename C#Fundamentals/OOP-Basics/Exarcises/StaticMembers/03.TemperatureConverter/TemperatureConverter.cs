namespace _03.TemperatureConverter
{
    public class TemperatureConverter
    {
        public static double FromCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public static double FromFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
