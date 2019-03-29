using System;

public class MaxMethod
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggerNum = GetMin(firstNumber, secondNumber);
        int biggestNum = GetMin(thirdNumber, biggerNum);

        Console.WriteLine(biggestNum);
    }

    private static int GetMin(int firstNumber, int secondNumber)
    {
        return Math.Min(firstNumber, secondNumber);
    }
}