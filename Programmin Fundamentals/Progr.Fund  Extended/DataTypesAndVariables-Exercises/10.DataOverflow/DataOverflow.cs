using System;

public class DataOverflow
{
    public static void Main()
    {
        var firstNum = ulong.Parse(Console.ReadLine());
        var secondNum = ulong.Parse(Console.ReadLine());

        ulong biggerNum = Math.Max(firstNum, secondNum);
        ulong smallerNum = Math.Min(firstNum, secondNum);

        string bigType = string.Empty;
        string smallType = string.Empty;
        ulong smallNumType = 0;

        if (biggerNum > byte.MinValue && biggerNum <= byte.MaxValue)
        {
            bigType = "byte";
        }
        else if (biggerNum > ushort.MinValue && biggerNum <= ushort.MaxValue)
        {
            bigType = "ushort";
        }
        else if (biggerNum > uint.MinValue && biggerNum <= uint.MaxValue)
        {
            bigType = "uint";
        }
        else if (biggerNum > ulong.MinValue && biggerNum <= ulong.MaxValue)
        {
            bigType = "ulong";
        }

        if (smallerNum > byte.MinValue && smallerNum <= byte.MaxValue)
        {
            smallType = "byte";
            smallNumType = byte.MaxValue;
        }
        else if (smallerNum > ushort.MinValue && smallerNum <= ushort.MaxValue)
        {
            smallType = "ushort";
            smallNumType = ushort.MaxValue;
        }
        else if (smallerNum > uint.MinValue && smallerNum <= uint.MaxValue)
        {
            smallType = "uint";
            smallNumType = uint.MaxValue;
        }
        else if (smallerNum > ulong.MinValue && smallerNum <= ulong.MaxValue)
        {
            smallType = "ulong";
            smallNumType = ulong.MaxValue;
        }

        Console.WriteLine($"bigger type: {bigType}");
        Console.WriteLine($"smaller type: {smallType}");
        Console.WriteLine($"{biggerNum} can overflow {smallType} {Math.Round((double)biggerNum / smallNumType)} times");

    }
}
