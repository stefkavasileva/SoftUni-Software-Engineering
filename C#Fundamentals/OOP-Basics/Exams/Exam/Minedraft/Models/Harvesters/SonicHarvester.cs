using System;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    protected int SonicFactor
    {
        get => this.sonicFactor;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {this.SonicFactor}");
            }

            this.sonicFactor = value;
        }
    }

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        base.EnergyRequirement /= (double)this.sonicFactor;
    }
}
