using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RefactorVolumeOfPyramid
{
    static void Main(string[] args)
    {
        Console.Write("Length: ");
        double lenght = double.Parse(Console.ReadLine());

        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double hight = double.Parse(Console.ReadLine());

        double volume = (lenght * width * hight) / 3;

        Console.WriteLine("Pyramid Volume: {0:F2}", volume);

    }
}

