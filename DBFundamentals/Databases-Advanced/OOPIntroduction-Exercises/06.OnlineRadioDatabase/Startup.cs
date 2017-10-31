using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var songs = new List<Song>();

        var songsCount = int.Parse(Console.ReadLine());


        for (int i = 0; i < songsCount; i++)
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            try
            {
                var time = input[2].Split(':').ToArray();
                int digit1;
                int digit2;

                if (int.TryParse(time[0], out digit1) && int.TryParse(time[1], out digit2))
                {

                    if (digit1 * 60 + digit2 > 0 || digit1 * 60 + digit2 < 14 * 60 + 59)
                    {
                        songs.Add(new Song(input[0], input[1], digit1, digit2));
                        Console.WriteLine("Song added.");
                    }

                }
                else
                {
                    throw new InvalidSongLengthException();
                }


            }
            catch (Exception ise)
            {
                Console.WriteLine(ise.Message);
            }
        }

        var totalDuration = songs.Sum(x => x.Minutes * 60 + x.Seconds);

        var totalHours = totalDuration / 60 / 60;
        var totalMinutes = (totalDuration / 60) - (totalHours * 60);
        long totalSeconds = totalDuration % 60;


        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
    }
}

