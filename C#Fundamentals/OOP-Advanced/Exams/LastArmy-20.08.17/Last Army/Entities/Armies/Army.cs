using System.Collections.Generic;

public class Army : IArmy
{
    public IReadOnlyList<ISoldier> Soldiers { get; protected set; }

    public void AddSoldier(ISoldier soldier)
    {
   
    }

    public void RegenerateTeam(string soldierType)
    {
        throw new System.NotImplementedException();
    }
}

