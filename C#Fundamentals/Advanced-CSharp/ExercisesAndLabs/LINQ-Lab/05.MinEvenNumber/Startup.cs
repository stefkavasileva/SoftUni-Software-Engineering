using System;
using System.Linq;

namespace _05.MinEvenNumber
{
    public class Startup
    {
        public static void Main()
        {
            var evenNums = Console.ReadLine().Split().Select(double.Parse).Where(x => x % 2 == 0);
            Console.WriteLine(evenNums.Any() ? $"{evenNums.Min():f2}" : "No match");
        }
    }
}
