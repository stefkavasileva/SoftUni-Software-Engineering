using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters = new List<Harvester>();
    private List<Provider> providers = new List<Provider>();
    private double totalEnergyStored = 0.0;
    private double totalMinedOre = 0.0;
    private string mode = "Full";


    public string RegisterHarvester(List<string> arguments)
    {
        var harvesterType = arguments[0];
        var energy = double.Parse(arguments[3]);
        var oreOutput = double.Parse(arguments[2]);

        try
        {
            if (harvesterType.Equals("Hammer"))
            {
                harvesters.Add(new HammerHarvester(arguments[1], oreOutput, energy));
                return $"Successfully registered Hammer Harvester - {arguments[1]}";
            }

            if (harvesterType.Equals("Sonic"))
            {
                harvesters.Add(new SonicHarvester(arguments[1], oreOutput, energy, int.Parse(arguments[4])));
                return $"Successfully registered Sonic Harvester - {arguments[1]}";
            }

            throw new ArgumentException();
        }
        catch (ArgumentException exception)
        {
            return exception.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        try
        {
            switch (type)
            {
                case "Solar":
                    providers.Add(new SolarProvider(arguments[1], double.Parse(arguments[2])));
                    return $"Successfully registered {type} Provider - {arguments[1]}";
                case "Pressure":
                    providers.Add(new PressureProvider(arguments[1], double.Parse(arguments[2])));
                    return $"Successfully registered {type} Provider - {arguments[1]}";
                default: throw new ArgumentException();
            }
        }
        catch (ArgumentException exception)
        {
            return exception.Message;
        }

    }

    public string Day()
    {
        double dailyProvidedEnergy = this.providers.Sum(p => p.EnergyOutput);
        double requiredEnergyPerMode = 0;
        double minedOrePerMode = 0;
        double dailyMinedOre = 0;

        switch (this.mode)
        {
            case "Full":
                requiredEnergyPerMode = this.harvesters.Sum(h => h.EnergyRequirement);
                minedOrePerMode = this.harvesters.Sum(h => h.OreOutput);
                break;
            case "Half":
                requiredEnergyPerMode = this.harvesters.Sum(h => h.EnergyRequirement * 60 / 100);
                minedOrePerMode = this.harvesters.Sum(h => h.OreOutput * 50 / 100);
                break;
        }

        this.totalEnergyStored += dailyProvidedEnergy;

        if (!this.mode.Equals("Energy")) // in "Energy" mode there is no mining, only the providers work
        {
            if (requiredEnergyPerMode <= this.totalEnergyStored)
            {
                this.totalEnergyStored -= requiredEnergyPerMode;
                dailyMinedOre += minedOrePerMode;
                this.totalMinedOre += dailyMinedOre;
            }
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {dailyProvidedEnergy}");
        sb.AppendLine($"Plumbus Ore Mined: {dailyMinedOre}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        if (harvesters.Any(x => x.Id == arguments[0]))
        {
            return harvesters.First(x => x.Id == arguments[0]).ToString();
        }

        if (providers.Any(x => x.Id == arguments[0]))
        {
            return providers.First(x => x.Id == arguments[0]).ToString();
        }

        return $"No element found with id - {arguments[0]}";
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {(int)totalEnergyStored}");
        sb.AppendLine($"Total Mined Plumbus Ore: {(int)totalMinedOre}");

        return sb.ToString().Trim();
    }

    public void CommandInterpreter(string inputLine)
    {
        var arguments = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var comand = arguments[0];
        arguments = arguments.Skip(1).ToList();
        switch (comand)
        {
            case "RegisterHarvester":
                Console.WriteLine(this.RegisterHarvester(arguments));
                break;
            case "RegisterProvider":
                Console.WriteLine(this.RegisterProvider(arguments));
                break;
            case "Day":
                Console.WriteLine(this.Day());
                break;
            case "Mode":
                Console.WriteLine(this.Mode(arguments));
                break;
            case "Check":
                Console.WriteLine(this.Check(arguments));
                break;
            case "Shutdown":
                Console.WriteLine(this.ShutDown());
                break;
        }
    }
}

