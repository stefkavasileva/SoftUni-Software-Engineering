using System;

public class IntegerToHexAndBinary
{
    public static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        string binaryNum = Convert.ToString(inputNum, 2);
        string hexadecimalNum = Convert.ToString(inputNum, 16).ToUpper();

        Console.WriteLine(hexadecimalNum);
        Console.WriteLine(binaryNum);
    }
}
