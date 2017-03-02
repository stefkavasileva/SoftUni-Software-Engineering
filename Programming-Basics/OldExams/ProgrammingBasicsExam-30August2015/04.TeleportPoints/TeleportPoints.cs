using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TeleportPoints
{
    static void Main(string[] args)
    {
        //71/100
        string[] A = Console.ReadLine().Split();
        string[] B = Console.ReadLine().Split();
        string[] C = Console.ReadLine().Split();
        string[] D = Console.ReadLine().Split();
        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        double x1 = double.Parse(A[0]);
        double x2 = double.Parse(B[0]);
        double y1 = double.Parse(B[1]);
        double y2 = double.Parse(C[1]);


        double count = 0;

        for (double x = x1 - 1; x < x2; x += step)
        {
            for (double y = y1 - 1; y < y2; y += step)
            {
                bool isPodoubleInCircle = (x * x) + (y * y) < radius * radius;
                bool isInsideTheRectangle = (x >= x1 && x <= x2) && (y <= y2 && y >= y1);

                if (isPodoubleInCircle && isInsideTheRectangle)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}

