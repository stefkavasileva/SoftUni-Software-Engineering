using System;

public class BackToThePast
{
    public static void Main()
    {
        decimal heritage = decimal.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());

        for (int i = 1800; i <= endYear; i++)
        {
            if (i % 2 == 0)
            {
                heritage -= 12000;
            }
            else
            {
                int age = (i - 1800) + 18;
                heritage -= 12000 + (50 * age);
            }
        }   

        if (heritage >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritage);
        }
        else
        {
            Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(heritage));
        }
    }
}
