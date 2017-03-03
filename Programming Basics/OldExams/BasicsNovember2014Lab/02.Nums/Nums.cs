using System;

public class Nums
{
    public static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        for (int n = startNum; n <= endNum; n++)
        {
            double result = 0;
            if (n % 2 == 0)
            {
                result = Math.Sqrt(n);
            }
            else
            {
                result = n * n;
            }

            Console.WriteLine($"{result:f3}");
        }
    }
}
