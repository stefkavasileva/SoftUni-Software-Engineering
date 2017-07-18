using System;
using System.Text;

public abstract class Harvester : Worker
{
    protected Harvester(string id, double oreOutput, double energyRequirement) 
        : base(id)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    private string id;

    private double oreOutput;

    private double energyRequirement;

    public double EnergyRequirement
    {
        get => this.energyRequirement;
        protected set
        {
            if (value < 0.0 || value > 20000.0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.EnergyRequirement)}");
            }

            this.energyRequirement = value;
        }
    }

    public double OreOutput
    {
        get => this.oreOutput;
        protected set
        {
            if (value < 0.0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
            }

            this.oreOutput = value;
        }
    }

    public string Id
    {
        get => this.id;
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.Id)}");
            }

            this.id = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var typeName = GetType().Name.Equals("SonicHarvester") ? "Sonic" : "Hammer";

        sb.AppendLine($"{typeName} Harvester - {this.Id}");
        sb.AppendLine($"Ore Output: {(int)this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {(int)this.EnergyRequirement}");

        return sb.ToString().Trim();
    }
}

