using System.Collections.Generic;

public class Easy : Mission
{
    public Easy(string name, double enduranceRequired, double scoreToComplete, double wearLevelDecrement, IEnumerable<IAmmunition> missionWeapons) 
        : base(name, enduranceRequired, scoreToComplete, wearLevelDecrement, missionWeapons)
    {
    }
}

