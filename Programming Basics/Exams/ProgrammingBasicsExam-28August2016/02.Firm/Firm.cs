using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Firm
{
    static void Main(string[] args)
    {
        var nHours = int.Parse(Console.ReadLine());
        var nDays = int.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());
        var inHours = 0.0;
        inHours = (nDays * 8) + ((workers * 2) * nDays) - (0.1 * nDays * 8); //Тук се получава: 3*8+1*2*3-0,1*3*8 = 24+6-2,4=27,6
        if (inHours >= nHours)
        {
            var diff = 0.0;
            diff = inHours - nHours;
            Console.WriteLine($"Yes!{diff = Math.Floor(diff)} hours left.");
        }
        else
        {
            var diff = 0.0;
            diff = nHours - inHours;//99-27.6=71.4
            Console.WriteLine($"Not enough time!{diff = Math.Ceiling(diff)} hours needed.");
        }
    }
}


