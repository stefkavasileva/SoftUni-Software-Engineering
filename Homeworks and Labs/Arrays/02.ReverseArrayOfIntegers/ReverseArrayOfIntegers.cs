using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseArrayOfIntegers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] nums = new string[n];

        for (int i = 0; i < n; i++)
        {
            string num = Console.ReadLine();
            nums[i] = num;
        }

        Array.Reverse(nums);
        Console.WriteLine(string.Join(" ",nums));
    }
}

