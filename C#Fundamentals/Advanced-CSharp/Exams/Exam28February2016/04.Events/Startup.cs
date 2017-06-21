using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Events
{
    public class Startup
    {
        public static void Main()
        {
            var reg = new Regex(@"^#([A-Za-z]+):\s*@([A-Za-z]+)\s*(\d{2}):(\d{2})$");
            var count = int.Parse(Console.ReadLine());
            var events = new Dictionary<string, Dictionary<string, List<DateTime>>>();

            for (int i = 0; i < count; i++)
            {
                var inputLine = Console.ReadLine();
                var match = reg.Match(inputLine);

                if (match.Success)
                {
                    var eventName = match.Groups[2].Value;
                    var personName = match.Groups[1].Value;
                    var hour = int.Parse(match.Groups[3].Value);
                    var minutes = int.Parse(match.Groups[4].Value);
                    if (hour < 0 || hour > 23 || minutes > 0 && minutes > 59)
                    {
                        continue;
                    }

                    var time = new DateTime(2016, 01, 01, hour, minutes, 00);

                    if (!events.ContainsKey(eventName))
                    {
                        events.Add(eventName, new Dictionary<string, List<DateTime>>());
                    }

                    if (!events[eventName].ContainsKey(personName))
                    {
                        events[eventName].Add(personName, new List<DateTime>());
                    }

                    events[eventName][personName].Add(time);
                }
            }

            var locations = Console.ReadLine().Split(',').Select(l => l.Trim()).ToList();
            var currentEvents = new Dictionary<string, Dictionary<string, List<DateTime>>>();

            foreach (var location in locations)
            {
                if (events.ContainsKey(location))
                {
                    currentEvents.Add(location, events[location]);
                }
            }

            currentEvents = currentEvents.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var currentEvent in currentEvents)
            {
                var counter = 1;
                Console.WriteLine($"{currentEvent.Key}:");

                foreach (var person in currentEvent.Value.OrderBy(x => x.Key))
                {
                    Console.Write($"{counter}. {person.Key} -> ");
                    counter++;
                    var times = new List<string>();

                    foreach (var time in person.Value.OrderBy(x => x))
                    {
                        times.Add(time.ToString("HH:mm"));
                    }

                    Console.WriteLine(string.Join(", ", times));
                }
            }
        }
    }
}
