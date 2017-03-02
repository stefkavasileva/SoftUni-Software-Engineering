using System;

public class SumsStepThree
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (i % 3 == 0)
            {
                sum1 += num;
            }
            else if (i % 3 == 1)
            {
                sum2 += num;
            }
            else if (i % 3 == 2)
            {
                sum3 += num;
            }
        }

        Console.WriteLine("sum1 = {0}", sum1);
        Console.WriteLine("sum2 = {0}", sum2);
        Console.WriteLine("sum3 = {0}", sum3);
    }
}
