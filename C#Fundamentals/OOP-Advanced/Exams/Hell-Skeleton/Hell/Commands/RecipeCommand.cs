using System.Collections.Generic;

public class RecipeCommand : AbstractCommand
{
    public RecipeCommand(IList<string> args, IManager manager)
        : base(args, manager)
    {
    }

    public override string Execute()
    {
        return base.Manager.AddRecipe(this.ArgsList);
    }
}

