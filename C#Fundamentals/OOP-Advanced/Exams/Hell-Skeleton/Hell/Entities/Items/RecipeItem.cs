using System.Collections.Generic;

public class RecipeItem : AbstractItem, IRecipe
{
    private IList<string> requiredItems;
    public RecipeItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus, IList<string> requiredItems)
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {
        this.RequiredItems = requiredItems;
    }

    public IList<string> RequiredItems
    {
        get => this.requiredItems;
        protected set => this.requiredItems = value;
    }
}
