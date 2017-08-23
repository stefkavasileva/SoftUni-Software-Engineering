using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private const int EnduranceIncreaseValue = 10;
    private const int MaxEnduranceValue = 300;

    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    protected Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
        this.OverallSkill = this.Age + this.Endurance;
        this.Weapons = new Dictionary<string, IAmmunition>();
    }

    public string Name { get; protected set; }
    public int Age { get; protected set; }
    public double Experience { get; protected set; }
    public double Endurance { get; protected set; }
    public double OverallSkill { get; protected set; }

    public IDictionary<string, IAmmunition> Weapons { get; protected set; }

    public virtual void Regenerate()
    {
        this.Endurance += EnduranceIncreaseValue + this.Endurance;

        if (this.Endurance > MaxEnduranceValue)
        {
            this.Endurance = 100;
        }
    }

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
        throw new System.NotImplementedException();
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