using System;

public class ExchangeVariableValues
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());

        var tempNum = firstNum;
        firstNum = secondNum;
        secondNum = tempNum;

        Console.WriteLine(firstNum);
        Console.WriteLine(secondNum);
    }
}