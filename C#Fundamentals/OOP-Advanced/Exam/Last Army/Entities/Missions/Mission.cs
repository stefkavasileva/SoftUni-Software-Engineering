using System.Collections.Generic;

public abstract class Mission : IMission
{
    protected Mission(string name, double enduranceRequired, double scoreToComplete, double wearLevelDecrement, IEnumerable<IAmmunition> missionWeapons)
    {
        this.Name = name;
        this.EnduranceRequired = enduranceRequired;
        this.ScoreToComplete = scoreToComplete;
        this.WearLevelDecrement = wearLevelDecrement;
        this.MissionWeapons = missionWeapons;
    }

    public string Name { get; }
    public double EnduranceRequired { get; }
    public double ScoreToComplete { get; }
    public double WearLevelDecrement { get; }
    public IEnumerable<IAmmunition> MissionWeapons { get; set; }
}
