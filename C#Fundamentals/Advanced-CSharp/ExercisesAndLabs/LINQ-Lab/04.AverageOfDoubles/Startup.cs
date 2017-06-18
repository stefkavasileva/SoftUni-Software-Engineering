using System;
using System.Linq;

namespace _04.AverageOfDoubles
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine($"{Console.ReadLine().Split().Select(double.Parse).Average():f2}");
        }
    }
}
