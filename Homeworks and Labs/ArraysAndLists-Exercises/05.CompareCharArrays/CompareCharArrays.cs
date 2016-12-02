using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareCharArrays
{
    static void Main(string[] args)
    {
        char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        bool isEquals = true;
        if (arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    isEquals = false;
                }
            }
            if (isEquals)
            {
                Console.WriteLine(arr1);
                Console.WriteLine(arr2);
            }
            else
            {
                if (arr1[0] > arr2[0])
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                }
                else
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                }
            }
        }
        else
        {
            int lent = Math.Min(arr2.Length, arr1.Length);
            for (int i = 0; i < lent; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    isEquals = false;
                }
            }
            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(arr2);
                Console.WriteLine(arr1);
            }
            else
            {
                Console.WriteLine(arr1);
                Console.WriteLine(arr2);
            }

        }
    }
}

