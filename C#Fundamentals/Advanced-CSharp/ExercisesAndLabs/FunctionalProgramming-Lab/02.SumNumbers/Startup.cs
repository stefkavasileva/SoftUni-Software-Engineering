using System;
using System.Linq;

namespace _02.SumNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
