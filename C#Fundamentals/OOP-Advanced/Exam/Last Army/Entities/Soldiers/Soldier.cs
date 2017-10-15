using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private string name;
    private int age;
    private double experience;
    private double overallSkill;
    private double endurance;
    private readonly IDictionary<string, IAmmunition> weapons;

    protected Soldier(string name, int age, double experience, double endurance)
    {
        this.Endurance = endurance;
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
        //this.OverallSkill = overallSkill;
        //this.weapons = weapons;
    }

    public string Name
    {
        get => this.name;
        protected set => this.name = value;
    }

    public int Age
    {
        get => this.age;
        protected set => this.age = value;
    }

    public double Experience
    {
        get => this.experience;
        protected set => this.experience = value;
    }

    public double Endurance
    {
        get => this.endurance;
        protected set => this.endurance = value;
    }

    public double OverallSkill
    {
        get => this.overallSkill;
        protected set => this.overallSkill = value;
    }

    public IDictionary<string, IAmmunition> Weapons => this.weapons;

    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    public int SuccessMissionCounter { get; set; }

    public abstract void Regenerate();

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    }

    public void CompleteMission(IMission mission)
    {
        //// some logic 
        /// 
        /// 
        /// 
        this.SuccessMissionCounter++;
    }

    private void AmmunitionRevision(double missionWearLevelDecrement)
    {
        IEnumerable<string> keys = this.Weapons.Keys.ToList();
        foreach (string weaponName in keys)
        {
            this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

            if (this.Weapons[weaponName].WearLevel <= 0)
            {
                this.Weapons[weaponName] = null;
            }
        }
    }

    public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);
}