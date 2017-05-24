using System;
using System.Collections.Generic;
using System.Text;

namespace _5.HotPotato
{
    public class Program
    {
        public static void Main()
        {
            var childrenNames = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(childrenNames);

            var sb = new StringBuilder();

            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    string name = queue.Dequeue();
                    queue.Enqueue(name);
                }

                sb.AppendLine($"Removed {queue.Dequeue()}");
            }

            sb.AppendLine($"Last is {queue.Dequeue()}");

            Console.WriteLine(sb.ToString().Trim());
            
        }
    }
}
