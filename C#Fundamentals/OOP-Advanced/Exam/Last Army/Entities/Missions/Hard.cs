using System.Collections.Generic;

public class Hard : Mission
{
    public Hard(string name, double enduranceRequired, double scoreToComplete, double wearLevelDecrement, IEnumerable<IAmmunition> missionWeapons)
        : base(name, enduranceRequired, scoreToComplete, wearLevelDecrement, missionWeapons)
    {
    }
}

