using System;
using System.Collections.Generic;

public static class FoodFactory
{
    public static IList<IFood> ProduceFood(string input)
    {
        var foods = new List<IFood>();
        var inputData = input.ToLower().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var entry in inputData)
        {
            switch (entry)
            {
                case "cram":
                    foods.Add(new Cram());
                    break;
                case "lembas":
                    foods.Add(new Lembas());
                    break;
                case "apple":
                    foods.Add(new Apple());
                    break;
                case "melon":
                    foods.Add(new Melon());
                    break;
                case "honeycake":
                    foods.Add(new HoneyCake());
                    break;
                case "mushrooms":
                    foods.Add(new Mushrooms());
                    break;
                default:
                    foods.Add(new OtherFood());
                    break;
            }
        }

        return foods;
    }
}
