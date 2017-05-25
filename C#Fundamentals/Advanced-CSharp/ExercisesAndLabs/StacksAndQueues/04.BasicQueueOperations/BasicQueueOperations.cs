using System;
using System.Collections.Generic;
using System.Linq;

public class BasicQueueOperations
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
        var resultNumbers = new Queue<int>();

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

    public static void PopNumbers(Queue<int> resultNumbers, int popCount)
    {
        for (int i = 0; i < popCount; i++)
        {
            if (resultNumbers.Any())
            {
                resultNumbers.Dequeue();
            }
        }
    }

    public static void PushNumbers(Queue<int> inputNumbers, Queue<int> resultNumbers, int pushCount)
    {
        for (int i = 0; i < pushCount; i++)
        {
            if (inputNumbers.Any())
            {
                resultNumbers.Enqueue(inputNumbers.Dequeue());
            }
        }
    }
}