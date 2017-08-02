using System.Collections;
using System.Collections.Generic;

public class Player
{
    public IList<Card> Cards { get; set; }
    public string Name { get; set; }

    public Player(string name)
    {
        this.Name = name;
        this.Cards = new List<Card>();
    }
}

