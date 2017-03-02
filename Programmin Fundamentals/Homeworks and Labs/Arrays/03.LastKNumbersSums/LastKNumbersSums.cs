using System;

public class LastKNumbersSums
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] arr = new long[n];
        arr[0] = 1;
        for (int i = 1; i < n; i++)
        {
            arr[i] = SumNum(arr, i - k, i - 1);
        }

        Console.WriteLine(string.Join(" ", arr));
    }

    private static long SumNum(long[] arr, int startIndex, int endIndex)
    {
        long sum = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i >= 0)
            {
                sum += arr[i];
            }
        }

        return sum;
    }
}