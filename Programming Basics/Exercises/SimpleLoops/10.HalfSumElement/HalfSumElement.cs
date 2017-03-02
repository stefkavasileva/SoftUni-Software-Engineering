using System;

public class HalfSumElement
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOfElement = 0;
        int maxNum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sumOfElement += num;

            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        if ((sumOfElement - maxNum) == maxNum)
        {
            Console.WriteLine("Yes Sum = {0}", maxNum);
        }
        else
        {
            Console.WriteLine("No Diff = {0}", Math.Abs(((sumOfElement - maxNum)) - maxNum));
        }
    }
}
