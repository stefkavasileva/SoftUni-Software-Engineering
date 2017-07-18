public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        base.OreOutput += oreOutput * 2;
        base.EnergyRequirement = energyRequirement + energyRequirement;
    }
}
