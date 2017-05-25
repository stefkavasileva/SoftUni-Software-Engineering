using System;
using System.Collections.Generic;
using System.Linq;

public class BasicStackOperations
{
    public static void Main()
    {
        var inputArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var pushCount = inputArgs[0];
        var popCount = inputArgs[1];
        var chackNum = inputArgs[2];

        var inputLine = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        var inputNumbers = new Queue<int>(inputLine);
        var resultNumbers = new Stack<int>();

        PushNumbers(inputNumbers, resultNumbers, pushCount);
        PopNumbers(resultNumbers, popCount);

        if (resultNumbers.Contains(chackNum))
        {
            Console.WriteLine("true");
        }
        else
        {
            if (resultNumbers.Any())
            {
                Console.WriteLine(resultNumbers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }

    public static void PopNumbers(Stack<int> resultNumbers, int popCount)
    {
        for (int i = 0; i < popCount; i++)
        {
            if (resultNumbers.Any())
            {
                resultNumbers.Pop();
            }
        }
    }

    public static void PushNumbers(Queue<int> inputNumbers, Stack<int> resultNumbers, int pushCount)
    {
        for (int i = 0; i < pushCount; i++)
        {
            if (inputNumbers.Any())
            {
                resultNumbers.Push(inputNumbers.Dequeue());
            }
        }
    }
}

