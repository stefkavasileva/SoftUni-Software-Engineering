public abstract class Food : IFood
{
    protected Food(int happiness)
    {
        this.Happiness = happiness;
    }

    public int Happiness { get; set; }
}