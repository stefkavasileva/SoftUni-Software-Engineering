using System.Collections.Generic;

public static class MoodFactory
{
    public static void ChangeMood(IMood person, IList<IFood> foods)
    {
        foreach (var food in foods)
        {
            person.Mood += food.Happiness;
        }
    }
}