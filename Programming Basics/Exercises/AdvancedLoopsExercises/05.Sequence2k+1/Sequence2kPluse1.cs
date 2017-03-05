using System;

public class Sequence2kPluse1
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        while (num <= n)
        {
            Console.WriteLine(num);
            num = (num * 2) + 1;
        }
    }
}
