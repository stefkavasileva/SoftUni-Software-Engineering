using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {      
        var realNums = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var numsCount = new SortedDictionary<double,int>();

        foreach (var number in realNums)
        {
            if (!numsCount.ContainsKey(number))
            {              
                numsCount.Add(number,0);   
            }

            numsCount[number]++;
        }

        foreach (var kvp in numsCount)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}