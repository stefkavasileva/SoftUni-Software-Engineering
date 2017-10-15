using System.Collections.Generic;

public class Corporal : Soldier
{
    private const double OverallSkillMiltiplier = 2.5;
    private const int RegenerateIncreaseValue = 10;

    private readonly IReadOnlyList<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "Helmet",
        "Knife"

    };



    protected override IReadOnlyList<string> WeaponsAllowed => this.weaponsAllowed;

    public override void Regenerate()
    {
        this.Endurance += RegenerateIncreaseValue + this.Age;
    }

    public Corporal(string name, int age, double experience, double endurance) 
        : base(name, age, experience, endurance)
    {
    }
}

