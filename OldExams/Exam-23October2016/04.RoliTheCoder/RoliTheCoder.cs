namespace _04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class RoliTheCoder
    {
        public static void Main()
        {
            ////90/100
            var events = new List<Event>();

            var inputLine = Console.ReadLine();

            while (!inputLine.ToLower().Equals("time for code"))
            {
                var reg = new Regex(@"(\d+)\s\#(\w+)((\s\@\w+)*)");
                var match = reg.Match(inputLine);

                if (match.Success)
                {
                    var id = match.Groups[1].Value.Trim();
                    var name = match.Groups[2].Value.Trim();
                    var participants = match.Groups[3].Value.Split().Where(x => x != string.Empty).ToList();

                    if (!events.Any(x => x.Id == id))
                    {
                        var currentEvent = new Event(name, id, new SortedSet<string>());
                        events.Add(currentEvent);
                    }

                    if (events.First(x => x.Id == id).Name == name)
                    {
                        var curentParticipants = events.First(x => x.Id == id).Participants;
                        participants.ForEach(x => curentParticipants.Add(x));
                        events.First(x => x.Id == id).Participants = curentParticipants;
                    }
                }

                inputLine = Console.ReadLine();
            }

            events = events
                .OrderByDescending(x => x.Participants.Count())
                .ThenBy(x => x.Name)
                .ToList();

            foreach (var currentEvent in events)
            {
                Console.WriteLine($"{currentEvent.Name} - {currentEvent.Participants.Count()}");

                foreach (var participant in currentEvent.Participants.OrderBy(x => x))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }
}