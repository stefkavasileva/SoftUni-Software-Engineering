using System;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "SQUEEEAAAK!";
    }

    public override void Eat(Food food)
    {
        if (!food.GetType().Name.Equals(nameof(Vegetable)))
        {
            throw new ArgumentException($"{nameof(Mouse)}s are not eating that type of food!");
        }

        this.FoodEaten += food.Quantity;
    }
}
