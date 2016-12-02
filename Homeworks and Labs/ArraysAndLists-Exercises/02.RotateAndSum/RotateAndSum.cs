using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RotateAndSum
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        int[] sum = new int[nums.Length];



        for (int r = 0; r < k; r++)
        {
            int lastElement = nums[nums.Length - 1];
            int[] rotated = new int[nums.Length];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                rotated[i + 1] = nums[i];

            }
            rotated[0] = lastElement;

            for (int i = 0; i < rotated.Length; i++)
            {
                sum[i] += rotated[i];

            }
            nums = rotated;
        }

        foreach (int num in sum)
        {
            Console.Write(num);
            Console.Write(" ");
        }
    }
}

