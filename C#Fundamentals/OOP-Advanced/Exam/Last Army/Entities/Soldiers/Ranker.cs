using System.Collections.Generic;

public class Ranker : Soldier
{
    private const double OverallSkillMiltiplier = 1.5;
    private const int RegenerateIncreaseValue = 10;

    private readonly IReadOnlyList<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet",

    };


    protected override IReadOnlyList<string> WeaponsAllowed { get; }

    public override void Regenerate()
    {
        this.Endurance += RegenerateIncreaseValue + this.Age;
    }

    public Ranker(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
    {

    }
}

