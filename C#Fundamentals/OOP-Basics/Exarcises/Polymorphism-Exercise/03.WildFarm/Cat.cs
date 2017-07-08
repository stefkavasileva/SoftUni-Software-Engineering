public class Cat : Felime
{
    public string Breed { get; set; }

    public Cat(string name, double weight, string livingRegion,string bread) 
        : base(name, weight, livingRegion)
    {
        this.Breed = bread;
    }

    public override string MakeSound()
    {
        return "Meowwww";
    }

    public override void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{typeof(Cat)}[{this.Name}, {this.Breed}, {this.Weight}, {this.Region}, {this.FoodEaten}]";
    }
}
