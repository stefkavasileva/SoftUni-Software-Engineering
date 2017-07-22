using System.Collections.Generic;

public interface ICommando : ISpecialisedSoldier
{
    IList<IMission> Missions { get; }
}