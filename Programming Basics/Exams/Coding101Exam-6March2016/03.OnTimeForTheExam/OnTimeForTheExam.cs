using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OnTimeForTheExam
{
    static void Main(string[] args)
    {
        int hourExam = int.Parse(Console.ReadLine());
        int minutesExam = int.Parse(Console.ReadLine());
        int hourArival = int.Parse(Console.ReadLine());
        int minutesArival = int.Parse(Console.ReadLine());

        int totalMinutesExam = (hourExam * 60) + minutesExam;
        int totalMinutesArival = (hourArival * 60) + minutesArival;
        string result = string.Empty;

        if (totalMinutesArival > totalMinutesExam)
        {
            Console.WriteLine("Late");

            int hours = Math.Abs((totalMinutesArival - totalMinutesExam) / 60);
            int minutes = Math.Abs((totalMinutesArival - totalMinutesExam) % 60);

            if (hours > 0)
            {
                result = hours + ":" + "0" + minutes;
                Console.WriteLine("{0}:{1:00} hours after the start", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0} minutes after the start", minutes);

            }
        }
        else if (totalMinutesExam - totalMinutesArival <= 30)
        {
            Console.WriteLine("On time");
            if (totalMinutesArival == totalMinutesExam)
            {
                return;
            }
            int minutes = Math.Abs((totalMinutesArival - totalMinutesExam) % 60);

            Console.WriteLine("{0} minutes before the start", minutes);
        }
        else
        {
            Console.WriteLine("Early");

            int hours = Math.Abs((totalMinutesArival - totalMinutesExam) / 60);
            int minutes = Math.Abs((totalMinutesArival - totalMinutesExam) % 60);

            if (hours > 0)
            {
                Console.WriteLine("{0}:{1:00} hours before the start", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0:00} minutes before the start", minutes);
            }

        }
    }
}

