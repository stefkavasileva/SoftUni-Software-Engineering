using System;
using System.Linq;

public class TrippleSum
{
    public static void Main()
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