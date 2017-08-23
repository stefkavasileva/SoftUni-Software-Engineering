using System.Collections.Generic;

public class Ranker : Soldier
{
    private const double OverallSkillMiltiplier = 1.5;

    private readonly IList<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "Helmet",
        };

    public Ranker(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
        base.OverallSkill *= OverallSkillMiltiplier;
    }

    protected override IReadOnlyList<string> WeaponsAllowed { get; }
}

