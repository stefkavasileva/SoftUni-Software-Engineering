using System;
using System.Linq;

namespace _07.BoundedNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var boundNums = Console.ReadLine().Split().Select(int.Parse);
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).Where(x => x >= boundNums.Min() && x <= boundNums.Max())));
        }
    }
}
