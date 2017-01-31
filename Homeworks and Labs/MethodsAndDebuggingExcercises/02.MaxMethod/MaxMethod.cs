using System;

public class MaxMethod
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggerNum = GetMax(firstNumber, secondNumber);
        int biggestNum = GetMax(thirdNumber, biggerNum);

        Console.WriteLine(biggestNum);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        return Math.Max(firstNumber, secondNumber);
    }
}
