using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayManipulator
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var messages = new StringBuilder();

            var comand = Console.ReadLine();
            while (!comand.Equals("end"))
            {
                var tokens = comand.Split();
                var comandName = tokens[0];

                if (comandName.Equals("exchange"))
                {
                    ExchangeNumbers(numbers, int.Parse(tokens[1]));
                }
                else if (comandName.Equals("first") || comandName.Equals("last"))
                {
                    var count = int.Parse(tokens[1]);
                    if (numbers.Count + count >= numbers.Count)
                    {
                        messages.AppendLine("Invalid count");
                        comand = Console.ReadLine();
                        continue;
                    }

                    var currentNumbers = new List<int>();

                    if (comandName.Equals("last")) numbers.Reverse();

                    currentNumbers = tokens[2].Equals("even")
                        ? numbers.Where(x => x % 2 == 0).Take(count).ToList()
                        : numbers.Where(x => x % 2 != 0).Take(count).ToList();

                    messages.AppendLine($"[{string.Join(", ", currentNumbers)}]");
                }
                else
                {
                    var currentNumbers = tokens[1].Equals("even")
                        ? numbers.Where(x => x % 2 == 0).ToList()
                        : numbers.Where(x => x % 2 != 0).ToList();

                    if (currentNumbers.Count() == 0)
                    {
                        messages.AppendLine("No matches");
                        comand = Console.ReadLine();
                        continue;
                    }

                    var index = tokens[0].Equals("min")
                        ? numbers.LastIndexOf(currentNumbers.Min())
                        : numbers.LastIndexOf(currentNumbers.Max());

                    messages.AppendLine(index >= 0 ? index.ToString() : "No matches");
                }


                comand = Console.ReadLine();
            }

            messages.AppendLine($"[{string.Join(", ", numbers)}]");
            Console.Write(messages);
        }

        private static void ExchangeNumbers(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
    }
}
