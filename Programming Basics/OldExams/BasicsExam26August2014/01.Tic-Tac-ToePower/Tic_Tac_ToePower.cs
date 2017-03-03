using System;

public class Tic_Tac_ToePower
{
    public static void Main()
    {
        int y = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int startValue = int.Parse(Console.ReadLine());
        int index = (x * 3) + y + 1;
        int currentNum = startValue + index - 1;

        long result = (long)Math.Pow(currentNum, index);

        Console.WriteLine(result);
    }
}
