using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private List<string> warsList = new List<string>();
    private Dictionary<string, List<Bender>> benders = new Dictionary<string, List<Bender>>();
    private Dictionary<string, List<Monument>> monuments = new Dictionary<string, List<Monument>>();

    public void CommandInterpreter(string inputLine)
    {
        var tokens = inputLine.Split().ToList();
        var commandName = tokens[0];

        switch (commandName)
        {
            case "Bender":
                AssignBender(tokens);
                break;
            case "Monument":
                AssignMonument(tokens);
                break;
            case "Status":
                GetStatus(tokens[1]);
                break;
            case "War":
                IssueWar(tokens[1]);
                break;
            case "Quit":
                Console.WriteLine(GetWarsRecord());
                break;
        }
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[1];
        var name = benderArgs[2];
        var power = int.Parse(benderArgs[3]);
        var secondaryParameter = double.Parse(benderArgs[4]);

        switch (type)
        {
            case "Air":
                CreateAirBender(name, power, secondaryParameter);
                break;
            case "Water":
                CreateWaterBender(name, power, secondaryParameter);
                break;
            case "Fire":
                CreateFireBender(name, power, secondaryParameter);
                break;
            case "Earth":
                CreateEarthBender(name, power, secondaryParameter);
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[1];
        var name = monumentArgs[2];
        var affinity = int.Parse(monumentArgs[3]);

        switch (type)
        {
            case "Air":
                CreateAirMonument(name, affinity);
                break;
            case "Water":
                CreateWaterMonument(name, affinity);
                break;
            case "Fire":
                CreateFireMonument(name, affinity);
                break;
            case "Earth":
                CreateEarthMonument(name, affinity);
                break;
        }
    }

    public void GetStatus(string nationsType)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{nationsType} Nation");
        if (benders.ContainsKey(nationsType))
        {
            sb.AppendLine("Benders:");
            sb.AppendLine(string.Join(Environment.NewLine, benders[nationsType]));
        }
        else
        {
            sb.AppendLine("Benders: None");
        }

        if (monuments.ContainsKey(nationsType))
        {
            sb.AppendLine("Monuments:");
            sb.AppendLine(string.Join(Environment.NewLine, monuments[nationsType]));
        }
        else
        {
            sb.AppendLine("Monuments: None");
        }

        Console.WriteLine(sb.ToString().Trim());
    }

    public void IssueWar(string nationsType)
    {
        warsList.Add(nationsType);
        var maxPower = long.MinValue;
        var winnerName = string.Empty;

        foreach (var bender in benders)
        {
            var currentPower = bender.Value.Sum(x => x.Power);
            var monumentsPower = 0L;

            if (monuments.ContainsKey(bender.Key))
            {
                monumentsPower = monuments[bender.Key].Sum(x => x.GetPowe());
            }

            long totalPower = currentPower + (currentPower / 100) * monumentsPower;
            if (totalPower > maxPower)
            {
                maxPower = totalPower;
                winnerName = bender.Key;
            }
        }

        if(winnerName.Equals(string.Empty)) return;

        var winner = new KeyValuePair<string, List<Bender>>(winnerName, benders[winnerName]);
        benders.Clear();
        benders.Add(winner.Key, new List<Bender>(winner.Value));

        if (!monuments.ContainsKey(winner.Key))
        {
            monuments.Clear();
            return;
        }

        var winnerMonuments = monuments[winner.Key];
        monuments.Clear();
        monuments.Add(winner.Key, winnerMonuments);
    }

    public string GetWarsRecord()
    {
        var sb = new StringBuilder();

        for (int i = 0; i < warsList.Count; i++)
        {
            sb.AppendLine($"War {i + 1} issued by {warsList[i]}");
        }

        return sb.ToString().Trim();
    }

    private void CreateEarthMonument(string name, int affinity)
    {
        if (!monuments.ContainsKey("Earth"))
        {
            monuments.Add("Earth", new List<Monument>());
        }

        monuments["Earth"].Add(new EarthMonument(name, affinity));
    }

    private void CreateFireMonument(string name, int affinity)
    {
        if (!monuments.ContainsKey("Fire"))
        {
            monuments.Add("Fire", new List<Monument>());
        }

        monuments["Fire"].Add(new FireMonument(name, affinity));
    }

    private void CreateWaterMonument(string name, int affinity)
    {
        if (!monuments.ContainsKey("Water"))
        {
            monuments.Add("Water", new List<Monument>());
        }

        monuments["Water"].Add(new WaterMonument(name, affinity));
    }

    private void CreateAirMonument(string name, int affinity)
    {
        if (!monuments.ContainsKey("Air"))
        {
            monuments.Add("Air", new List<Monument>());
        }

        monuments["Air"].Add(new AirMonument(name, affinity));
    }

    private void CreateEarthBender(string name, int power, double secondaryParameter)
    {
        if (!benders.ContainsKey("Earth"))
        {
            benders.Add("Earth", new List<Bender>());
        }

        benders["Earth"].Add(new WaterBender(name, power, secondaryParameter));
    }

    private void CreateFireBender(string name, int power, double secondaryParameter)
    {
        if (!benders.ContainsKey("Fire"))
        {
            benders.Add("Fire", new List<Bender>());
        }

        benders["Fire"].Add(new FireBender(name, power, secondaryParameter));
    }

    private void CreateWaterBender(string name, int power, double secondaryParameter)
    {
        if (!benders.ContainsKey("Water"))
        {
            benders.Add("Water", new List<Bender>());
        }

        benders["Water"].Add(new WaterBender(name, power, secondaryParameter));
    }

    private void CreateAirBender(string name, int power, double secondaryParameter)
    {
        if (!benders.ContainsKey("Air"))
        {
            benders.Add("Air", new List<Bender>());
        }

        benders["Air"].Add(new AirBender(name, power, secondaryParameter));
    }
}

