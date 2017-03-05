using System;

public class NumbersFromNTo1
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = num; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}
