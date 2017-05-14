using System;

namespace _04.NumberInReversedOrder
{
    public class StartUp
    {
        public static void Main()
        {
            var decimalNumberAsStr = Console.ReadLine();
            var decimalNumber = new DecimalNumber(decimalNumberAsStr);
            var reversedDecimalNum = decimalNumber.ReverseNumber(decimalNumberAsStr);

            Console.WriteLine(reversedDecimalNum);

        }
    }
}
