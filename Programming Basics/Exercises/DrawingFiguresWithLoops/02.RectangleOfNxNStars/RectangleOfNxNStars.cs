using System;

public class RectangleOfNxNStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine(new string('*', n));
        }
    }
}
