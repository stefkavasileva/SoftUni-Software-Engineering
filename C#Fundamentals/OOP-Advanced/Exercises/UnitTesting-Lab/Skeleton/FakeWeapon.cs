public class FakeWeapon : IWeapon
{
    public int AttackPoints
    {
        get { return 10; }
    }

    public int DurabilityPoints
    {
        get { return 20; }
    }

    public void Attack(ITarget target)
    {
        target.TakeAttack(this.AttackPoints);
    }
}