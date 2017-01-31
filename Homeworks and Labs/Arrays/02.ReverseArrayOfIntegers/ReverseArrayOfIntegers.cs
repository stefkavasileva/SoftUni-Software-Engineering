using System;

public class ReverseArrayOfIntegers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] nums = new string[n];

        for (int i = 0; i < n; i++)
        {
            string num = Console.ReadLine();
            nums[i] = num;
        }

        Array.Reverse(nums);
        Console.WriteLine(string.Join(" ", nums));
    }
}
