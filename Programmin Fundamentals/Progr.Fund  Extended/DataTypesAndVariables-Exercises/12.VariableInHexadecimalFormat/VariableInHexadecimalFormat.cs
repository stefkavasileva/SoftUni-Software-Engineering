using System;

public class VariableInHexFormat
{
    public static void Main()
    {
        string hexadecimalNum = Console.ReadLine();

        int decimalNum = Convert.ToInt32(hexadecimalNum, 16);

        Console.WriteLine(decimalNum);
    }
}
