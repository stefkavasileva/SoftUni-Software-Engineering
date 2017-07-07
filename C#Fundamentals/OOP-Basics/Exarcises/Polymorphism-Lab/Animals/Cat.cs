using System;

public class Cat : Animal
{
    public Cat(string name, string favoriteFood)
    {
        base.Name = name;
        base.FavoriteFood = favoriteFood;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEEOW";
    }
}

