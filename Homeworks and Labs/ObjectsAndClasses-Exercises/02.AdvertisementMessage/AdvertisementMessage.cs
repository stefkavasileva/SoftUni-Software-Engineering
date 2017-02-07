using System;

public class AdvertisementMessage
{
    public static void Main()
    {
        int messages = int.Parse(Console.ReadLine());

        string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        Random rand = new Random();

        for (int i = 0; i < messages; i++)
        {
            int phrasesIndex = rand.Next(0, phrases.Length);
            int eventsIndex = rand.Next(0, events.Length);
            int authorIndex = rand.Next(0, author.Length);
            int citiesIndex = rand.Next(0, cities.Length);

            Console.WriteLine("{0} {1} {2}",
                phrases[phrasesIndex],
                events[eventsIndex],
                author[authorIndex],
                cities[citiesIndex]);
        }
    }
}
