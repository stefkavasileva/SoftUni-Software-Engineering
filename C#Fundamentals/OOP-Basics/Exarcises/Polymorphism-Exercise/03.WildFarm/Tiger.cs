using System;

public class Tiger : Felime
{
    public Tiger(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "ROAAR!!!";
    }

    public override void Eat(Food food)
    {
        if (!food.GetType().Name.Equals(nameof(Meat)))
        {
            throw new ArgumentException($"{nameof(Tiger)}s are not eating that type of food!");
        }

        this.FoodEaten += food.Quantity;
    }
}
