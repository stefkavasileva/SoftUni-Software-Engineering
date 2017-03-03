using System;

public class Triangle
{
    public static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double a = Math.Sqrt(((bX - aX) * (bX - aX)) + ((bY - aY) * (bY - aY)));
        double c = Math.Sqrt(((bX - cX) * (bX - cX)) + ((bY - cY) * (bY - cY)));
        double b = Math.Sqrt(((cX - aX) * (cX - aX)) + ((cY - aY) * (cY - aY)));

        bool isTriangle = false;

        if (a + b > c && b + c > a && a + c > b)
        {
            isTriangle = true;
        }

        if (isTriangle)
        {
            Console.WriteLine("Yes");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"{area:f2}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"{a:f2}");
        }
    }
}