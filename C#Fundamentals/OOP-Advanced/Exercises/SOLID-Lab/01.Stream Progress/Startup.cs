using System;

namespace _01.Stream_Progress
{
    public class Startup
    {
        public static void Main()
        {
            var file = new File("Test",12,12);
            var music = new Music("Some name","Cool",15,2222);

            var stramFileInfo = new StreamProgressInfo(file);
            var stramMusicInfo = new StreamProgressInfo(music);

            Console.WriteLine(stramFileInfo.CalculateCurrentPercent());
            Console.WriteLine(stramMusicInfo.CalculateCurrentPercent());
        }
    }
}
