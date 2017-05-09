using System;
using System.Linq;

public class AppliedArithmetics
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Action<int[]> myActions = nums => { };

        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine.Equals("end")) break;

            myActions = AddActions(myActions, inputLine);
        }

        myActions(numbers);
    }

    private static Action<int[]> AddActions(Action<int[]> myActions, string inputLine)
    {
        if (inputLine.Equals("add"))
        {
            myActions += AddOne;
        }
        else if (inputLine.Equals("multiply"))
        {
            myActions += MultiplyByTwo;
        }
        else if (inputLine.Equals("subtract"))
        {
            myActions += SubstractOne;
        }
        else
        {
            myActions += Print;
        }

        return myActions;
    }

    public static void AddOne(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i]++;
        }
    }

    public static void MultiplyByTwo(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2;
        }
    }

    public static void SubstractOne(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i]--;
        }
    }

    public static void Print(int[] numbers)
    {
        Console.WriteLine(string.Join(" ", numbers));
    }

}

