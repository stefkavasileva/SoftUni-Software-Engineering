using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RoliTheCoder
{
    static void Main(string[] args)
    {
        string inputEvent = Console.ReadLine();

        var events = new Dictionary<string, Dictionary<string, List<string>>>();

        while (!inputEvent.Equals("Time for Code"))
        {
            string[] eventsArgs = inputEvent
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            string id = eventsArgs[0];
            string name = eventsArgs[1].Substring(1);
            string[] participants = new string[eventsArgs.Length - 2];

            GetParticipants(eventsArgs, participants);


            if (!eventsArgs[1].Contains('#'))
            {
                inputEvent = Console.ReadLine();
                continue;
            }


            if (!events.ContainsKey(id))
            {
                events.Add(id, new Dictionary<string, List<string>>());
                events[id].Add(name, new List<string>());
            }

            if (events[id].ContainsKey(name))
            {
                events[id][name].AddRange(participants);
            }

            inputEvent = Console.ReadLine();
        }


        var sortedEvents = new Dictionary<string, List<string>>();

        sortedEvents = SortEvents(events, sortedEvents);

        foreach (var e in sortedEvents)
        {
            Console.WriteLine($"{e.Key} - {e.Value.Count}");

            foreach (var participant in e.Value.OrderBy(x => x))
            {
                Console.WriteLine($"{participant}");
            }
        }
    }

    private static Dictionary<string, List<string>> SortEvents(Dictionary<string, Dictionary<string, List<string>>> events, Dictionary<string, List<string>> sortedEvents)
    {
        foreach (var eventArgs in events.Values)
        {
            foreach (var e in eventArgs)
            {
                sortedEvents.Add(e.Key, new List<string>());
                sortedEvents[e.Key].AddRange(e.Value.Distinct().ToList());
            }
        }

        sortedEvents = sortedEvents.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        return sortedEvents;
    }

    private static void GetParticipants(string[] eventsArgs, string[] participants)
    {
        for (int i = 2; i < eventsArgs.Length; i++)
        {
            participants[i - 2] = eventsArgs[i];
        }
    }
}

