using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WorkHours
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int productivity = int.Parse(Console.ReadLine());

        int workHours = (int)((days - days * 0.1) * 12 * (productivity / 100.0));

        if (workHours - hours < 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }

        Console.WriteLine(workHours - hours);

    }

}

