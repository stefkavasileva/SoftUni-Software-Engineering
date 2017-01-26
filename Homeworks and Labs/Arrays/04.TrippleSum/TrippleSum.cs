using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TrippleSum
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isContains = false;
        for (int a = 0; a < arr.Length - 1; a++)
        {
            for (int b = a + 1; b < arr.Length; b++)
            {
                int sum = arr[a] + arr[b];
                if (arr.Contains(sum))
                {
                    Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                    isContains = true;
                }
            }
        }

        if (!isContains)
        {
            Console.WriteLine("No");
        }
    }
}

