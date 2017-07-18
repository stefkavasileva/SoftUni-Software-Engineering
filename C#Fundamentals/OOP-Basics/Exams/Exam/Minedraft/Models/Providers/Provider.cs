using System;
using System.Text;

public abstract class Provider : Worker
{
    protected Provider(string id, double energyOutput) 
        : base(id)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    private string id;
    private double energyOutput;

    public double EnergyOutput
    {
        get => this.energyOutput;
        protected set
        {
            if (value < 0.0 || value >= 10000.0)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }

            this.energyOutput = value;
        }
    }

    public string Id
    {
        get => this.id;
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.Id)}");
            }

            this.id = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var typeName = GetType().Name.Equals("SolarProvider") ? "Solar" : "Pressure";

        sb.AppendLine($"{typeName} Provider - {this.Id}");
        sb.AppendLine($"Energy Output: {(int)this.EnergyOutput}");
        return sb.ToString().Trim();
    }
}

