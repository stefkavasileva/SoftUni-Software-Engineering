using System;

public class Dog : Animal
{
    public Dog(string name, string favoriteFood)
    {
        base.Name = name;
        base.FavoriteFood = favoriteFood;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}

