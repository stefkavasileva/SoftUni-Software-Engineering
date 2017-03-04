using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ShootListElements
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var numbers = new List<int>();
        var messages = new StringBuilder();
        var lastRemovedElement = int.MinValue;

        while (!inputLine.Equals("stop"))
        {
            int currentNum;
            var isNumber = int.TryParse(inputLine, out currentNum);

            if (isNumber)
            {
                numbers.Insert(0, currentNum);
                inputLine = Console.ReadLine();
                continue;
            }

            var average = numbers.Count() > 0 ? numbers.Average() : -1;
            var isRemoved = false;
            ShotNumber(numbers, messages, ref lastRemovedElement, average, ref isRemoved);

            if (isRemoved)
            {
                DecrementNumbers(numbers);

            }
            else
            {
                messages.AppendLine($"nobody left to shoot! last one was {lastRemovedElement}");
                Console.Write(messages);
                return;
            }

            inputLine = Console.ReadLine();
        }

        if (numbers.Any())
        {
            messages.AppendLine($"survivors: {string.Join(" ", numbers)}");
        }
        else
        {
            messages.AppendLine($"you shot them all. last one was {lastRemovedElement}");
        }

        Console.Write(messages);
    }

    public static void DecrementNumbers(List<int> numbers)
    {
        if (numbers.Any())
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i]--;
            }
        }
    }

    public static void ShotNumber(List<int> numbers, StringBuilder messages, ref int lastRemovedElement, double average, ref bool isRemoved)
    {
        for (int i = 0; i < numbers.Count(); i++)
        {
            if (numbers[i] <= average)
            {
                messages.AppendLine($"shot {numbers[i]}");
                lastRemovedElement = numbers[i];
                numbers.RemoveAt(i);
                isRemoved = true;
                break;
            }
        }
    }
}
