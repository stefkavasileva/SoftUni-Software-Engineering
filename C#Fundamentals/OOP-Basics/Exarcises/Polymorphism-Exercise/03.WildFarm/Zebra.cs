using System;

public class Zebra : Mammal
{
    public Zebra(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "Zs";
    }

    public override void Eat(Food food)
    {
        if (!food.GetType().Name.Equals(nameof(Vegetable)))
        {
            throw new ArgumentException($"{nameof(Zebra)}s are not eating that type of food!");
        }

        this.FoodEaten += food.Quantity;
    }
}
