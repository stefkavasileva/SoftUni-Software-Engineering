using System.Collections.Generic;

public interface IRecipe
{
    string Name { get; }

    IList<string> RequiredItems { get; }

    long StrengthBonus { get; }

    long AgilityBonus { get;  }

    long IntelligenceBonus { get; }

    long HitPointsBonus { get;  }

    long DamageBonus { get; }
}

