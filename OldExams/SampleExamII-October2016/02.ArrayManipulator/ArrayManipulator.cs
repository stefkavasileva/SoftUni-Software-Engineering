using System;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        int[] inputArr = Console.ReadLine()
           .Split().Select(int.Parse).ToArray();

        string comand = Console.ReadLine().ToLower();

        while (!comand.Equals("end"))
        {
            string[] comandArgs = comand.Split().Select(x => x.Trim()).ToArray();

            if (comandArgs[0].Equals("exchange"))
            {
                if (int.Parse(comandArgs[1]) < 0 || int.Parse(comandArgs[1]) >= inputArr.Length)
                {
                    Console.WriteLine("Invalid index");
                    comand = Console.ReadLine();
                    continue;
                }

                inputArr = ExchangeArr(inputArr, int.Parse(comandArgs[1]));
            }
            else if (comandArgs[0].Equals("first") || comandArgs[0].Equals("last"))
            {
                int count = int.Parse(comandArgs[1]);

                if (count < 0 || count > inputArr.Length)
                {
                    Console.WriteLine("Invalid count");
                    comand = Console.ReadLine();
                    continue;
                }

                int[] nums = new int[] { };

                if (comandArgs[0].Equals("first"))
                {
                    nums = GetFirstNNums(inputArr, count, comandArgs[2]);
                }
                else
                {
                    Array.Reverse(inputArr);
                    nums = GetFirstNNums(inputArr, count, comandArgs[2]);
                    Array.Reverse(nums);
                    Array.Reverse(inputArr);
                }

                Console.WriteLine($"[{string.Join(", ", nums)}]");
            }
            else
            {
                int index = 0;

                if (comandArgs[0].Equals("max"))
                {
                    index = GetMaxIndex(inputArr, comandArgs[1]);
                }
                else
                {
                    index = GetMinIndex(inputArr, comandArgs[1]);
                }

                IsMatch(index);
            }

            comand = Console.ReadLine().ToLower();
        }

        Console.WriteLine("[{0}]", string.Join(", ", inputArr));
    }

    private static int[] GetFirstNNums(int[] inputArr, int size, string typeOfNum)
    {
        int[] result = new int[size];

        if (typeOfNum.Equals("odd"))
        {
            result = inputArr.Where(x => x % 2 != 0).Take(size).ToArray();
        }
        else
        {
            result = inputArr.Where(x => x % 2 == 0).Take(size).ToArray();
        }

        return result;
    }

    private static void IsMatch(int index)
    {
        if (index < 0)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(index);
        }
    }

    private static int GetMinIndex(int[] inputArr, string numberType)
    {
        int index = -1;
        int minNum = int.MaxValue;

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (numberType.Equals("even"))
            {
                if (inputArr[i] <= minNum && inputArr[i] % 2 == 0)
                {
                    minNum = inputArr[i];
                    index = i;
                }
            }
            else
            {
                if (inputArr[i] <= minNum && inputArr[i] % 2 != 0)
                {
                    minNum = inputArr[i];
                    index = i;
                }
            }
        }

        return index;
    }

    private static int GetMaxIndex(int[] inputArr, string numberType)
    {
        int index = -1;
        int maxNum = int.MinValue;

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (numberType.Equals("even"))
            {
                if (inputArr[i] >= maxNum && inputArr[i] % 2 == 0)
                {
                    maxNum = inputArr[i];
                    index = i;
                }
            }
            else
            {
                if (inputArr[i] >= maxNum && inputArr[i] % 2 != 0)
                {
                    maxNum = inputArr[i];
                    index = i;
                }
            }
        }

        return index;
    }

    private static int[] ExchangeArr(int[] inputArr, int index)
    {
        int[] firstElements = inputArr.Where((x, i) => i <= index).ToArray();
        inputArr = inputArr.Where((x, i) => i > index).ToArray();
        inputArr = inputArr.Concat(firstElements).ToArray();

        return inputArr;
    }
}
