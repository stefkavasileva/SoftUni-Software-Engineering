using System.Collections.Generic;

public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;
    private const int RegenerateIncreaseValue = 30;

    private readonly IReadOnlyList<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "RPG",
            "Helmet",
            "Knife",
            "NightVision"
        };

    //Old constructor
    //public SpecialForce(string name, int age, double experience, double endurance)
    //    : base(name, age, experience, endurance)
    //{
    //}


    protected override IReadOnlyList<string> WeaponsAllowed => this.weaponsAllowed;

    public override void Regenerate()
    {
        this.Endurance += RegenerateIncreaseValue + this.Age;
    }

    public SpecialForce(string name, int age, double experience, double endurance) 
        : base(name, age, experience, endurance)
    {
    }
}
