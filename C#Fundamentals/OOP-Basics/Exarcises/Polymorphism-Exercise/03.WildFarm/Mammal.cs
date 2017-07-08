public abstract class Mammal : Animal
{
    protected string LivingRegion { get; set; }

    protected Mammal(string name, double weight,string livingRegion)
        : base(name, weight,livingRegion)
    {
        this.LivingRegion = livingRegion;
    }
}
