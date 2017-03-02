using System;

public class GenerateRectangles
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        bool isRectangle = false;

        for (int left = -n; left <= 0; left++)
        {
            for (int top = -n; top <= 0; top++)
            {
                for (int right = 0; right <= n; right++)
                {
                    for (int bottom = 0; bottom <= n; bottom++)
                    {
                        int area = (top - bottom) * (left - right);

                        if (-n <= left &&
                            left < right &&
                            right <= n &&
                            -n <= top &&
                            top < bottom &&
                            bottom <= n && area >= m)
                        {
                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                            isRectangle = true;

                        }
                    }
                }
            }
        }

        if (!isRectangle)
        {
            Console.WriteLine("No");
        }
    }
}
