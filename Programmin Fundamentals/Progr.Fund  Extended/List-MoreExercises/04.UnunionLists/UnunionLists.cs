using System;
using System.Collections.Generic;
using System.Linq;

public class UnunionLists
{
    public static void Main()
    {
        var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
        var arrCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < arrCount; i++)
        {
            var currentArr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var tempList = new List<int>();

            GetUniqueElements(primalList, currentArr, tempList);
            GetUniqueElements(currentArr, primalList, tempList);

            primalList = tempList;
        }

        primalList.Sort();
        Console.WriteLine(string.Join(" ", primalList));
    }

    private static void GetUniqueElements(List<int> primalList, List<int> currentArr, List<int> tempList)
    {
        for (int j = 0; j < primalList.Count; j++)
        {
            var num = primalList[j];
            if (!currentArr.Contains(num))
            {
                tempList.Add(primalList[j]);
            }
        }
    }
}

