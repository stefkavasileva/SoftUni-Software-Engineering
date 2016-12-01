using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AppendLists
{
    static void Main(string[] args)
    {

        var input = Console.ReadLine().Split('|').ToList();
        input.Reverse();
        Console.WriteLine(string.Join(" ", input));

        //    string inputLine = Console.ReadLine();
        //    string[] stringArrs = inputLine.Split('|').ToArray();
        //    Array.Reverse(stringArrs);
        //    List<int> nums = new List<int>();

        //    ConvertArrToList(stringArrs, nums);    
        //    PrintList(nums);

    }

    //private static void PrintList(List<int> nums)
    //{
    //    Console.WriteLine(string.Join(" ", nums));
    //}

    //private static void ConvertArrToList(string[] stringArrs, List<int> nums)
    //{
    //    for (int i = 0; i < stringArrs.Length; i++)
    //    {
    //        string currentStr = stringArrs[i];
    //        AddNums(nums, i, currentStr);
    //    }
    //}

    //private static void AddNums(List<int> nums, int i, string currentStr)
    //{
    //    for (int j = 0; j < currentStr.Length; j++)
    //    {
    //        if (char.IsDigit(currentStr[j]))
    //        {
    //            nums.Add((int)char.GetNumericValue(currentStr[j]));
    //        }
    //    }
    //}

}

