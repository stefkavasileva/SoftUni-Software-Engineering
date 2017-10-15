using System.Collections.Generic;

public class Medium : Mission
{
    public Medium(string name, double enduranceRequired, double scoreToComplete, double wearLevelDecrement, IEnumerable<IAmmunition> missionWeapons)
        : base(name, enduranceRequired, scoreToComplete, wearLevelDecrement, missionWeapons)
    {
    }
}

