public abstract class Animal
{
    protected string Name { get; set; }
    public double Weight { get; set; }
    public int FoodEaten { get; set; }
    public string Region { get; set; }

    protected Animal(string name, double weight,string region)
    {
        this.Name = name;
        this.Weight = weight;
        this.Region = region;
    }

    public abstract string MakeSound();

    public abstract void Eat(Food food);

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Weight}, {this.Region}, {this.FoodEaten}]";
    }
}
