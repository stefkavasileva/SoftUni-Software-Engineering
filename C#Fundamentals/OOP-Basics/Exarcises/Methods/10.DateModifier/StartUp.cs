using System;

namespace _10.DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            var firstDateAsStr = Console.ReadLine();
            var secondDateAsStr = Console.ReadLine();

            var result = DateModifier.GetDaysBeetwenTwoDate(firstDateAsStr, secondDateAsStr);
            Console.WriteLine(Math.Abs(result));
        }
    }
}
