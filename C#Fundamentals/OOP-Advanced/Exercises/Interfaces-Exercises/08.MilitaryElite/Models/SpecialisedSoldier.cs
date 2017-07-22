using System;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    protected SpecialisedSoldier(string id, string firstName, string lastName, double salary,string crops)
        : base(id, firstName, lastName, salary)
    {
        this.Crops = crops;
    }

    public string Crops { get; }

    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}Corps: {this.Crops}{Environment.NewLine}";
    }
}
