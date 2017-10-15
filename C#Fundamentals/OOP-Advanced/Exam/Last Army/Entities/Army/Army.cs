using System.Collections.Generic;

public class Army : IArmy
{
    private IReadOnlyList<ISoldier> soldiers;

    public IReadOnlyList<ISoldier> Soldiers
    {
        get => this.soldiers;
        protected set => this.soldiers = value;
    }

    public Army(IReadOnlyList<ISoldier> soldiers)
    {
        this.Soldiers = soldiers;
    }

    public void AddSoldier(ISoldier soldier)
    {
       var soldierFactories = new SoldiersFactory();
    }

    public void RegenerateTeam(string soldierType)
    {
        throw new System.NotImplementedException();
    }
}

