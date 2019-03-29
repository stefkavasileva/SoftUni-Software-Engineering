namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participantsNames = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var participants = new List<Participant>();

            foreach (var participantName in participantsNames)
            {
                if (!participants.Any(x => x.Name == participantName))
                {
                    var currentParticipant = new Participant(participantName, new HashSet<string>());
                    participants.Add(currentParticipant);
                }
            }

            var songs = Console.ReadLine().Split(',').Select(x => x.Trim());

            var comand = Console.ReadLine();

            while (!comand.ToLower().Equals("dawn"))
            {
                var performanceArgs = comand.Split(',').Select(x => x.Trim()).ToArray();
                var participantName = performanceArgs[0];
                var song = performanceArgs[1];
                var award = performanceArgs[2];

                if (participantsNames.Contains(participantName) && songs.Contains(song))
                {
                    var currentParicipants = participants.First(x => x.Name == participantName);
                    currentParicipants.Awards.Add(award);
                }

                comand = Console.ReadLine();
            }

            participants = participants.Where(x => x.Awards.Count > 0).OrderByDescending(x => x.Awards.Count()).ThenBy(x => x.Name).ToList();
            bool hasPerformance = false;

            foreach (var participant in participants)
            {
                Console.WriteLine($"{participant.Name}: {participant.Awards.Count()} awards");
                var currentAwards = participant.Awards.OrderBy(x => x);

                foreach (var award in currentAwards)
                {
                    Console.WriteLine($"--{award}");
                    hasPerformance = true;
                }
            }

            if (!hasPerformance)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
