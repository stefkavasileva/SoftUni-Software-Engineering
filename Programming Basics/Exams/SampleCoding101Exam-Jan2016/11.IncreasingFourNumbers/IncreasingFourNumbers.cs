using System;

public class IncreasingFourNumbers
{
    public static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        bool isSpecialNum = false;

        for (int num1 = startNum; num1 <= endNum; num1++)
        {
            for (int num2 = startNum; num2 <= endNum; num2++)
            {
                for (int num3 = startNum; num3 <= endNum; num3++)
                {
                    for (int num4 = startNum; num4 <= endNum; num4++)
                    {
                        if (startNum <= num1 &&
                            num1 < num2 &&
                            num2 < num3 &&
                            num3 < num4 &&
                            num4 <= endNum)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", num1, num2, num3, num4);
                            isSpecialNum = true;
                        }
                    }
                }
            }
        }

        if (!isSpecialNum)
        {
            Console.WriteLine("No");
        }
    }
}