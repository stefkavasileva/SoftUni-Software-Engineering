using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountNumbers
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        nums.Sort();

        int maxNum= nums.Max();

        for (int i = 0; i <=maxNum; i++)
        {
            if (nums.Contains(i))
            {
                int count = nums.Count(x => x == i);
                Console.WriteLine($"{i} -> {count}");
            }
        }

       
    }
}

