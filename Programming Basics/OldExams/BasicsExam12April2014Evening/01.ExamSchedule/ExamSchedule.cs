using System;

public class ExamSchedule
{
    public static void Main()
    {
        int startingHours = int.Parse(Console.ReadLine());
        int startingMinutes = int.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine().ToUpper();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());
        string timeStart = startingHours + ":" + startingMinutes;

        DateTime test = Convert.ToDateTime(timeStart);
        test = test.AddHours(durationHours);
        test = test.AddMinutes(durationMinutes);

        string reseult = test.ToString();
        string[] totalTime = reseult.Split(' ');
        string time = totalTime[1];

        if (partOfTheDay == "PM")
        {
            if (startingHours == 12 && durationHours == 11)
            {
                Console.WriteLine("{0}{1}", time.Substring(0, 6), totalTime[totalTime.Length - 1]);
                return;
            }

            test = test.AddHours(12);
            string[] h = time.Split(':');

            if (startingHours + durationHours >= 12 || (startingHours + durationHours == 11 && startingMinutes + durationMinutes >= 60))
            {
                if (h[0].Length != 2)
                {
                    Console.WriteLine("0{0}AM", time.Substring(0, 5));
                }
                else
                {
                    Console.WriteLine("{0}:AM", time.Substring(0, 5));
                }

            }
            else if (h[0].Length != 2)
            {
                Console.WriteLine("0{0}PM", time.Substring(0, 5));
            }
            else
            {
                Console.WriteLine("{0}:PM", time.Substring(0, 5));
            }
        }
        else
        {
            string[] h = time.Split(':');
            if (h[0].Length == 2)
            {
                Console.WriteLine("{0}{1}", time.Substring(0, 6), totalTime[totalTime.Length - 1]);
            }
            else
            {
                Console.WriteLine("0{0}{1}", time.Substring(0, 5), totalTime[totalTime.Length - 1]);
            }
        }
    }
}