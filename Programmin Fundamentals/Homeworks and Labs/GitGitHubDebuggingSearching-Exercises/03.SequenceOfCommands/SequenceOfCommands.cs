using System;
using System.Linq;

public class SequenceOfCommands
{
    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();
        int index = 0;
        int value = 0;

        while (!command.Equals("stop"))
        {
            string[] lineArgs = command.Split();

            if (!lineArgs[0].Equals("rshift") && !lineArgs[0].Equals("lshift"))
            {
                index = int.Parse(lineArgs[1]) - 1;
                value = int.Parse(lineArgs[2]);
            }

            switch (lineArgs[0])
            {
                case "multiply":
                    array[index] *= value;
                    break;
                case "add":
                    array[index] += value;
                    break;
                case "subtract":
                    array[index] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine();
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long lastNum = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastNum;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long firstNum = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = firstNum;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}