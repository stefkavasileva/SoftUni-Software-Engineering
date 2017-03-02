using System;

public class SumSeconds
{
    public static void Main()
    {
        int firstSeconds = int.Parse(Console.ReadLine());
        int secondSeconds = int.Parse(Console.ReadLine());
        int thirdSeconds = int.Parse(Console.ReadLine());

        int totalSecond = firstSeconds + secondSeconds + thirdSeconds;

        Console.Write("{0}:{1:00}", (totalSecond / 60), (totalSecond % 60));
    }
}
