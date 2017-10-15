public class Barbarian : AbstractHero
{
    private const int BarbarianStrength = 90;
    private const int BarbarianAgility = 25;
    private const int BarbarianIntelligence = 10;
    private const int BarbarianHitPoints = 350;
    private const int BarbarianDamage = 150;

    public Barbarian(string name)
        : base(name, BarbarianStrength, BarbarianAgility, BarbarianIntelligence, BarbarianHitPoints, BarbarianDamage)
    {

    }
}

