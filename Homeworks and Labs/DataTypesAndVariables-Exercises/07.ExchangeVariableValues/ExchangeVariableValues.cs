using System;

public class ExchangeVariableValues
{
    public static void Main()
    {
        int firstNum = 5;
        int secondNum = 10;

        Console.WriteLine("Before: ");
        Console.WriteLine($"a = {firstNum}");
        Console.WriteLine($"b = {secondNum}");

        int tempNum = secondNum;

        secondNum = firstNum;
        firstNum = tempNum;

        Console.WriteLine("After: ");
        Console.WriteLine($"a = {firstNum}");
        Console.WriteLine($"b = {secondNum}");
    }
}
