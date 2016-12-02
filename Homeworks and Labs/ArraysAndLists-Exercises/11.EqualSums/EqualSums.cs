using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EqualSums
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int leftSum = 0;
        int rightSum = 0;
        bool isEqualSum = false;
        for (int curruntNum = 0; curruntNum < numbers.Length; curruntNum++)
        {
            for (int left = 0; left < curruntNum; left++)
            {
                leftSum += numbers[left];
            }

            for (int right = curruntNum + 1; right < numbers.Length; right++)
            {
                rightSum += numbers[right];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(curruntNum);
                isEqualSum = true;
                break;
            }
            leftSum = 0;
            rightSum = 0;
        }

        if (!isEqualSum)
        {
            Console.WriteLine("no");
        }
    }
}

