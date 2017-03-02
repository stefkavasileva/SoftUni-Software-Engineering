using System;

public class NumbersInReversedOrder
{
    public static void Main()
    {
        char[] decimalNum = Console.ReadLine().ToCharArray();

        string reversedNum = ReverseNumber(decimalNum);
        Console.WriteLine(reversedNum);
    }

    private static string ReverseNumber(char[] decimalNum)
    {
        Array.Reverse(decimalNum);
        return string.Join(string.Empty, decimalNum);
    }
}
