using System;
using System.Linq;

namespace _06.FindAndSumIntegers
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !x.Any(y => char.IsLetter(y)))
                .Select(long.Parse);

            Console.WriteLine(numbers.Count().Equals(0) ? "No match" : numbers.Sum().ToString());
        }
    }
}
