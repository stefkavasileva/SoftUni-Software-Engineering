using System.Collections;
using System.Collections.Generic;

public interface IMission
{
    string Name { get; }

    double EnduranceRequired { get; }

    double ScoreToComplete { get; }

    double WearLevelDecrement { get; }

    //IEnumerable<IAmmunition> MissionWeapons { get; set; }
}
