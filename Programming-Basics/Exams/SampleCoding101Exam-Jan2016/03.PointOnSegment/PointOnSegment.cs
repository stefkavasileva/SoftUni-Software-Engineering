using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointOnSegment
{
    static void Main(string[] args)
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

