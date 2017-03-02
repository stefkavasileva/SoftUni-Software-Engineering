using System;

public class PointOnSegment
{
    public static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        int leftNum = Math.Min(firstNum, secondNum);
        int rightNum = Math.Max(firstNum, secondNum);

        if (point >= leftNum && point <= rightNum)
        {
            Console.WriteLine("in");
            int result = Math.Min((point - leftNum), (rightNum - point));
            Console.WriteLine(Math.Abs(result));
        }
        else
        {
            Console.WriteLine("out");
            int result = Math.Min((point - leftNum), (rightNum - point));
            Console.WriteLine(Math.Abs(result));
        }
    }
}