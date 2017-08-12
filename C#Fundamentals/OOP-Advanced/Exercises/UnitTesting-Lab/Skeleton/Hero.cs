public class Hero
{
    private string name;
    private int experience;
    private IWeapon weapon;

    public Hero(string name, IWeapon weapon)
    {
        this.name = name;
        this.experience = 0;
        this.weapon = weapon;
    }

    public string Name => this.name; 

    public int Experience => this.experience; 

    public IWeapon Weapon => this.weapon; 

    public void Attack(ITarget target)
    {
        this.weapon.Attack(target);

        if (target.IsDead())
        {
            this.experience += target.GiveExperience();
        }
    }
}
