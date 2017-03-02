using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TrainingLab
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());

        int site = (int)(((hight * 100) - 100) / 70.0);
        int rows = (int)((width * 100) / 120);

        int result = (site * rows) - 3;

        Console.WriteLine(result);
    }
}

