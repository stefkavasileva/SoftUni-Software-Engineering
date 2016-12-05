using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BombNumbers
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine()
            .Split().Select(int.Parse).ToList();

        int[] bomb = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();

        int bombNum = bomb[0];
        int power = bomb[1];
        DetonateNums(nums, bombNum, power);
        int sum = CalcSum(nums, bombNum);

        Console.WriteLine(sum);
    }

    private static int CalcSum(List<int> nums, int bombNum)
    {
        int sum = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == bombNum)
            {
                continue;
            }

            sum += nums[i];

        }

        return sum;
    }

    private static void DetonateNums(List<int> nums, int bombNum, int power)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == bombNum)
            {
                DetonateRightNum(nums, power, i);
                DetonateLeftNums(nums, power, i);
            }
        }
    }

    private static void DetonateRightNum(List<int> nums, int power, int i)
    {

        for (int j = 0; j < power; j++)
        {
            if (i + 1 < nums.Count)
            {
                nums.RemoveAt(i + 1);
            }
        }
    }

    private static void DetonateLeftNums(List<int> nums, int power, int i)
    {
        int index = i - power;
        for (int j = 0; j < power; j++)
        {
            if (index < 0)
            {
                index = 0;             
            }

            if (index>nums.Count-1)
            {
                continue;
            }

            nums.RemoveAt(index);
        }
    }
}

