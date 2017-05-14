using System;

namespace _03.LastDigitName
{
    public class LastDigitName
    {
        public static void Main()
        {
            var numberAsString = Console.ReadLine();
            var number = new Number(numberAsString);
            Console.WriteLine(number.GetName());
        }
    }
}
