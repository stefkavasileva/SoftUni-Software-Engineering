using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RepairingTheTiles
{
    static void Main(string[] args)
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

