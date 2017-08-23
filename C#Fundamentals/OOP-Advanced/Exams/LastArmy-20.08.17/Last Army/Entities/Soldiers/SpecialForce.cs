using System.Collections.Generic;

public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;
    private const int MaxEnduranceValue = 300;
    private const int EnduranceIncreaseValue = 30;

    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "RPG",
            "Helmet",
            "Knife",
            "NightVision"
        };

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
        this.OverallSkill += OverallSkillMiltiplier;
    }

    protected override IReadOnlyList<string> WeaponsAllowed => this.weaponsAllowed;

    public override void Regenerate()
    {
        this.Endurance += EnduranceIncreaseValue + this.Age;
        if (this.Endurance > MaxEnduranceValue)
        {
            this.Endurance = 100;
        }
    }
}
