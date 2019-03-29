using System;
using System.Collections.Generic;
using System.Linq;

public class Exercises
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var exercises = new List<Exercise>();

        while (!inputLine.Equals("go go go"))
        {
            var tokens = inputLine
                .Split("-> ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .ToArray();

            var topic = tokens[0];
            var courseName = tokens[1];
            var judgeContestLink = tokens[2];
            var problems = tokens.Skip(3).ToArray();

            if (!exercises.Any(e => e.Topic == topic))
            {
                var exercise = new Exercise(topic, courseName, judgeContestLink, new List<string>());
                exercise.Proglems.AddRange(problems);
                exercises.Add(exercise);
            }

            inputLine = Console.ReadLine();
        }

        foreach (var exercise in exercises)
        {
            Console.WriteLine($"Exercises: {exercise.Topic}");
            Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
            var count = 1;
            foreach (var problem in exercise.Proglems)
            {
                Console.WriteLine($"{count}. {problem}");
                count++;
            }
        }
    }
}
