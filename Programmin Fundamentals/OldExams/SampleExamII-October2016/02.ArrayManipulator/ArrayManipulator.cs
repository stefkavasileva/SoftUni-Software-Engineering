using System;
using System.Linq;
using System.Text;

public class ArrayManipulator
{
    public static void Main()
    {
        var result = new StringBuilder();

        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        var comand = Console.ReadLine();
        while (!comand.ToLower().Equals("end"))
        {
            var comandArgs = comand.Split();
            var action = comandArgs.First();

            if (action.Equals("exchange"))
            {
                var index = int.Parse(comandArgs[1]);
                if (index < 0 || index >= numbers.Count)
                {
                    result.AppendLine("Invalid index");
                    comand = Console.ReadLine();
                    continue;
                }

                var someNumbers = numbers.Skip(index + 1).ToArray();
                numbers.RemoveRange(index + 1, numbers.Count - index - 1);
                numbers.InsertRange(0, someNumbers);
            }
            else if (action.Equals("max") || action.Equals("min"))
            {
                var numberType = comandArgs.Last();

                var currentNums = numberType.Equals("even") ?
                    numbers.Where(x => x % 2 == 0) :
                    numbers.Where(x => x % 2 == 1);

                if (currentNums.Count() == 0)
                {
                    result.AppendLine("No matches");
                    comand = Console.ReadLine();
                    continue;
                }

                var number = action.Equals("max") ?
                    numbers.LastIndexOf(currentNums.Max()) :
                    numbers.LastIndexOf(currentNums.Min());

                result.AppendLine(number.ToString());
            }        
            else
            {
                var count = int.Parse(comandArgs[1]);

                if (count > numbers.Count)
                {
                    result.AppendLine("Invalid count");
                    comand = Console.ReadLine();
                    continue;
                }

                var currentNums = comandArgs[2].Equals("even") ?
                        numbers.Where(x => x % 2 == 0).ToList() :
                        numbers.Where(x => x % 2 != 0).ToList();

                if (action.Equals("first"))
                {
                    result.AppendLine($"[{string.Join(", ", currentNums.Take(count))}]");
                }
                else
                {
                    var skipCount = currentNums.Count - count;
                    result.AppendLine($"[{string.Join(", ", currentNums.Skip(skipCount))}]");
                }
            }

            comand = Console.ReadLine();
        }

        result.AppendLine($"[{string.Join(", ", numbers)}]");
        Console.Write(result.ToString());
    }
}
