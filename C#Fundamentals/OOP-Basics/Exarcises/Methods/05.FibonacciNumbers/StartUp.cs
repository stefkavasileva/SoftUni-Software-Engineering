using System;

namespace _05.FibonacciNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var startPossition = int.Parse(Console.ReadLine());
            var endPossition = int.Parse(Console.ReadLine());

            Fibonacci fibonacci = new Fibonacci();

            long f1 = 0;
            long f2 = 1;
            fibonacci.FibNumbers.Add(f1);
            fibonacci.FibNumbers.Add(f2);

            for (int i = 2; i <= endPossition; i++)
            {
                var sum = f1 + f2;
                f1 = f2;
                f2 = sum;

                fibonacci.FibNumbers.Add(f2);
            }

            fibonacci.FibNumbers = fibonacci.GetNumbersInRange(startPossition, endPossition);
            Console.WriteLine(fibonacci);
        }
    }
}
