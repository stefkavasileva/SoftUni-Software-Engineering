using System;
using System.Collections.Generic;
using System.Linq;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string firstName, string lastName, double salary, string crops)
        : base(id, firstName, lastName, salary, crops)
    {
        this.Missions = new List<IMission>();
    }

    public IList<IMission> Missions { get; }

    public override string ToString()
    {
        return $"{base.ToString()}Missions:{Environment.NewLine + "  "}{string.Join(Environment.NewLine + "  ", this.Missions)}".Trim();

    }
}
