namespace _04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main()
        {
            var events = new List<Event>();

            var inputLine = Console.ReadLine();

            while (!inputLine.ToLower().Equals("time for code"))
            {
                var eventsArgs = inputLine
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

                var id = eventsArgs[0];
                var name = eventsArgs[1].Substring(1);
                var participants = new List<string>();
                participants.AddRange(eventsArgs.Skip(2));

                if (eventsArgs[1].Contains('#'))
                {
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

                foreach (var participant in currentEvent.Participants)
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }
}