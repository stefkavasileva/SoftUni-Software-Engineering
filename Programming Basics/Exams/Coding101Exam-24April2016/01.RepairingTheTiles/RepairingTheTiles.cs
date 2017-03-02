using System;

public class RepairingTheTiles
{
    public static void Main()
    {
        int hightPlayground = int.Parse(Console.ReadLine());
        double widthTitle = double.Parse(Console.ReadLine());
        double hightTitle = double.Parse(Console.ReadLine());
        int widthBench = int.Parse(Console.ReadLine());
        int hightBench = int.Parse(Console.ReadLine());

        int playgroundArea = hightPlayground * hightPlayground;
        int benchArea = widthBench * hightBench;
        playgroundArea -= benchArea;
        double areaTitle = widthTitle * hightTitle;

        double neededTitle = playgroundArea / areaTitle;
        double neededTime = neededTitle * 0.2;

        Console.WriteLine(neededTitle);
        Console.WriteLine(neededTime);
    }
}