using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheaThePhotographer
{
    static void Main(string[] args)
    {
        int totalPics = int.Parse(Console.ReadLine());
        int filterTime = int.Parse(Console.ReadLine());
        int filterFactor = int.Parse(Console.ReadLine());
        int uploadTime = int.Parse(Console.ReadLine());

         int filteredPics = (int)Math.Ceiling(totalPics * (filterFactor / 100.0));

        long totalTime = (totalPics * (long)filterTime) + (filteredPics * (long)uploadTime);

        TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(totalTime));
        
        if (time.Days > 0)
        {
            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss")); 
        }
        else
        {
            Console.WriteLine( "0:"+time.ToString(@"hh\:mm\:ss"));
           
        }

    }
}

