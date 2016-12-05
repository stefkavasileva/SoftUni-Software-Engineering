using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArrayManipulator
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

        string comand = Console.ReadLine().ToLower();

        while (!comand.Equals("print"))
        {
            string[] comandArgs = comand.Split();

            if (comandArgs[0].Equals("add"))
            {
                int index = int.Parse(comandArgs[1]);
                int num = int.Parse(comandArgs[2]);
                nums.Insert(index, num);
            }
            else if (comandArgs[0].Equals("addmany"))
            {
                int index = int.Parse(comandArgs[1]);
                List<int> numsToAdd = new List<int>();

                for (int i = 2; i < comandArgs.Length; i++)
                {
                    numsToAdd.Add(int.Parse(comandArgs[i]));
                }

                nums.InsertRange(index, numsToAdd);
            }
            else if (comandArgs[0].Equals("contains"))
            {
                int element = int.Parse(comandArgs[1]);

                if (nums.Contains(element))
                {
                    Console.WriteLine(nums.IndexOf(element));
                }
                else
                {
                    Console.WriteLine(-1);
                }

            }
            else if (comandArgs[0].Equals("remove"))
            {
                int index = int.Parse(comandArgs[1]);
                nums.RemoveAt(index);
            }
            else if (comandArgs[0].Equals("shift"))
            {
                int position = int.Parse(comandArgs[1]);

                int temp = 0;
                for (int i = 0; i < position; i++)
                {
                    temp = nums[0];
                    nums.RemoveAt(0);
                    nums.Add(temp);
                }

            }
            else if (comandArgs[0].Equals("sumpairs"))
            {
                List<int> sums = new List<int>();

                for (int i = 1; i < nums.Count; i += 2)
                {
                    sums.Add(nums[i - 1] + nums[i]);
                }

                if (nums.Count % 2 != 0)
                {
                    sums.Add(nums[nums.Count - 1]);
                }

                nums = sums;
            }

            comand = Console.ReadLine().ToLower();
        }

        Console.WriteLine("[" + string.Join(", ", nums) + "]");

    }
}