using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    //60/100
    private static List<ISoldier> soldiers = new List<ISoldier>();

    public static void Main()
    {
        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("End"))
        {
            ParseDate(inputLine);
            inputLine = Console.ReadLine();
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }

    private static void ParseDate(string inputLine)
    {
        var tokens = inputLine.Split();
        if (tokens[0].Equals("Private"))
        {
            var @private = new Private(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]));
            soldiers.Add(@private);
            return;
        }

        if (tokens[0].Equals("LeutenantGeneral"))
        {
            var leutenantGeneral = new LeutenantGeneral(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]));
            var privateIds = tokens.Skip(5);
            var privates = GetPrivates(privateIds, soldiers);
            privates.ForEach(x => leutenantGeneral.Privates.Add(x));
            soldiers.Add(leutenantGeneral);
            return;
        }

        if (tokens[0].Equals("Engineer"))
        {
            var engineer = new Engineer(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
            var restOfTokens = tokens.Skip(6).ToList();
            var repairs = TakeRepairs(restOfTokens);
            foreach (var repair in repairs)
            {
                engineer.Repairs.Add(repair);
            }

            soldiers.Add(engineer);
            return;
        }

        if (tokens[0].Equals("Commando"))
        {
            if (tokens[5] != "Airforces" && tokens[5] != "Marines")
            {
                return;
            }

            var comando = new Commando(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
            var restOfTokens = tokens.Skip(6).ToList();
            var missions = TakeMission(restOfTokens);
            foreach (var mission in missions)
            {
                comando.Missions.Add(mission);
            }

            soldiers.Add(comando);
            return;
        }

        soldiers.Add(new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4])));
    }

    private static IList<IMission> TakeMission(List<string> restOfTokens)
    {
        var allMissions = new List<IMission>();
        for (int i = 0; i < restOfTokens.Count() - 1; i += 2)
        {
            var code = restOfTokens[i];
            var state = restOfTokens[i + 1];

            if(state!= "inProgress" && state != "Finished") continue;

            allMissions.Add(new Mission(code, state));
        }

        return allMissions;
    }

    private static IList<IRepair> TakeRepairs(IList<string> restOfTokens)
    {
        var allRepairs = new List<IRepair>();
        for (int i = 0; i < restOfTokens.Count() - 1; i += 2)
        {
            var part = restOfTokens[i];
            var hour = int.Parse(restOfTokens[i + 1]);
            allRepairs.Add(new Repair(part, hour));
        }

        return allRepairs;
    }

    private static List<IPrivate> GetPrivates(IEnumerable<string> privateIds, List<ISoldier> allPrivates)
    {
        var list = new List<IPrivate>();
        foreach (var id in privateIds)
        {
            if (allPrivates.Any(x => x.Id == id))
            {
                list.Add((IPrivate)allPrivates.First(x => x.Id == id));
            }
        }

        return list;
    }
}

