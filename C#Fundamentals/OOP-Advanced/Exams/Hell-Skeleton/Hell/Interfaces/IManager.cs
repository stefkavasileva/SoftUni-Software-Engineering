using System;
using System.Collections.Generic;

public interface IManager
{
    string AddHero(IList<string> arguments);

    string AddItemToHero(IList<String> arguments);

    string CreateGame();

    string Inspect(IList<String> arguments);

    string Quit(IList<string> args);

    string AddRecipe(IList<string> argsList);
}

