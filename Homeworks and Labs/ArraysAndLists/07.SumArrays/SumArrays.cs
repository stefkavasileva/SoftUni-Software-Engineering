using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumArrays
{
    static void Main(string[] args)
    {
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxLent = Math.Max(arr1.Length, arr2.Length);
        int len1 = arr1.Length;
        int len2 = arr2.Length;

        int[] result = new int[maxLent];


        for (int i = 0; i < maxLent; i++)
        {
            result[i] = arr1[i % len1] + arr2[i % len2];
        }


        foreach (int sum in result)
        {
            Console.Write(sum);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

