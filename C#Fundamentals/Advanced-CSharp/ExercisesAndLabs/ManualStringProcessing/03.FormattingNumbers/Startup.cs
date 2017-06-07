using System;
using System.Linq;

namespace _03.FormattingNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' ','\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var firstNumber = int.Parse(numbers[0]);
            var secondNum = double.Parse(numbers[1]);
            var thirdNumber = double.Parse(numbers[2]);

            var firstColInHex = $"|{firstNumber.ToString("X").PadRight(10, ' ')}";
            var secondColBinary = $"|{Convert.ToString(firstNumber, 2).PadLeft(10, '0').Substring(0, 10)}";
            var thirdCol = $"{secondNum:F2}".PadLeft(10,' ');
            var fourthCol = $"{thirdNumber:F3}".PadRight(10, ' ');

            Console.WriteLine($"{firstColInHex}{secondColBinary}|{thirdCol}|{fourthCol}|");
        }
    }
}
