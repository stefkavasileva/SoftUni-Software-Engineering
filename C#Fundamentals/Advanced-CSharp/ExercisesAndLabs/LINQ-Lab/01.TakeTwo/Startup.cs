using System;
using System.Linq;

namespace _01.TakeTwo
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(
                string.Join(" ",Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .Where(n => n >= 10 && n <= 20)
                .Take(2)));
        }
    }
}
