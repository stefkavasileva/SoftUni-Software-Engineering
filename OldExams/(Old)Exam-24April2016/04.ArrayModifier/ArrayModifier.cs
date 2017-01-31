using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayModifier
{
    public static void Main()
    {
        List<long> nums = Console.ReadLine().Split().Select(long.Parse).ToList();

        string[] comandInfo = Console.ReadLine().Split();

        while (comandInfo[0] != "end")
        {
            if (comandInfo[0] == "decrease")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i]--;
                }
            }
            else
            {
                string comand = comandInfo[0];
                int index1 = int.Parse(comandInfo[1]);
                int index2 = int.Parse(comandInfo[2]);

                if (comandInfo[0] == "swap")
                {
                    long oldValueInIndex1 = nums[index1];
                    long oldValueInIndex2 = nums[index2];

                    nums[index1] = oldValueInIndex2;
                    nums[index2] = oldValueInIndex1;
                }
                else
                {
                    nums[index1] = nums[index1] * nums[index2];
                }
            }

            comandInfo = Console.ReadLine().Split();
        }

        Console.WriteLine(string.Join(", ", nums));
    }
}
