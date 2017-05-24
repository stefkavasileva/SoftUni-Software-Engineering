using System;
using System.Collections.Generic;
using System.Text;

namespace _6.MathPotato
{
    public class Startup
    {
      public  static void Main()
        {
            var childrenNames = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(childrenNames);

            var sb = new StringBuilder();
            int circle = 1;

            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    string name = queue.Dequeue();
                    queue.Enqueue(name);
                }

                if (IsPrime(circle))
                {
                    sb.AppendLine($"Prime {queue.Peek()}");
                }
                else
                {
                    sb.AppendLine($"Removed {queue.Dequeue()}");
                }

                circle++;
            }

            sb.AppendLine($"Last is {queue.Dequeue()}");

            Console.WriteLine(sb.ToString().Trim());
        }

        public static bool IsPrime(long number)
        {
            if (number <= 1)
                return false;
            else if (number % 2 == 0)
                return number == 2;

            long N = (long)(Math.Sqrt(number) + 0.5);

            for (int i = 3; i <= N; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
