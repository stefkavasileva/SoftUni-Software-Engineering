public class Wizard : AbstractHero
{
    private const int WizardStrength = 90;
    private const int WizardAgility = 25;
    private const int WizardIntelligence = 10;
    private const int WizardHitPoints = 350;
    private const int WizardDamage = 150;

    public Wizard(string name)
        : base(name, WizardStrength, WizardAgility, WizardIntelligence, WizardHitPoints, WizardDamage)
    {

    }
}

