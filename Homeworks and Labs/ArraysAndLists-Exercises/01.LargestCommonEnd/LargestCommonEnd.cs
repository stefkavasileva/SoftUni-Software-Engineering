using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] firstWords = Console.ReadLine().Split(' ');
        string[] secondWords = Console.ReadLine().Split(' ');

        int leftCounter = CheckArrays(firstWords, secondWords);

        Array.Reverse(firstWords);
        Array.Reverse(secondWords);

        int rightCounter = CheckArrays(firstWords, secondWords); ;
        int max = Math.Max(leftCounter, rightCounter);

        Console.WriteLine(max);
    }

    private static int CheckArrays(string[] arr1, string[] arr2)
    {
        int minLent = Math.Min(arr1.Length, arr2.Length);
        int count = 0;
        for (int i = 0; i < minLent; i++)
        {
            if (arr1[i] == arr2[i])
            {
                count++;
            }
            else
            {
                break;
            }
        }
        return count;
    }
}

