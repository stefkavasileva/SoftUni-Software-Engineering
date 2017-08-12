public class FakeTarget : ITarget
{
    public int Health
    {
        get { return 0; }
    }

    public int Experience { get; }

    public void TakeAttack(int attackPoints)
    {
    }

    public int GiveExperience()
    {
        return 20;
    }

    public bool IsDead()
    {
        return true;
    }
}
