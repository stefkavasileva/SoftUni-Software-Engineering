namespace _07.AdvertisementMessage
{
    using System;
    using System.IO;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            int messages = int.Parse(Console.ReadLine());

            var phrases = File.ReadAllLines("phrases.txt");
            var events = File.ReadAllLines("events.txt");
            var author = File.ReadAllLines("author.txt");
            var cities = File.ReadAllLines("cities.txt");

            Random rand = new Random();
            File.WriteAllText("output.txt", string.Empty);

            for (int i = 0; i < messages; i++)
            {
                int phrasesIndex = rand.Next(0, phrases.Length);
                int eventsIndex = rand.Next(0, events.Length);
                int authorIndex = rand.Next(0, author.Length);
                int citiesIndex = rand.Next(0, cities.Length);

                File.AppendAllText("output.txt", $"{phrases[phrasesIndex]} {events[eventsIndex]} {author[authorIndex]} - {cities[citiesIndex]}{Environment.NewLine}");
            }
        }
    }
}
