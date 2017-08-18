public class KillEventArgs
{
    public KillEventArgs(Soldier soldier, King kingDefended)
    {
        this.Soldier = soldier;
        this.KingDefended = kingDefended;
    }

    public Soldier Soldier { get; }

    public King KingDefended { get; }
}
