using System.Collections.Generic;

public interface IEngineer : ISpecialisedSoldier
{
    IList<IRepair> Repairs { get; }
}