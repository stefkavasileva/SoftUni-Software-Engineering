using System;

public class Card : IComparable<Card>
{
    public Rank Rank { get; protected set; }
    public Suit Suit { get; protected set; }

    public Card()
    {
        
    }

    public Card(Rank rank, Suit suit)
    {
        this.Rank = rank;
        this.Suit = suit;
    }

    public int GetPower()
    {
        return (int)this.Rank + (int)this.Suit;
    }

    public override string ToString()
    {
        return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.GetPower()}";
    }

    public int CompareTo(Card other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var rankComparison = Rank.CompareTo(other.Rank);
        if (rankComparison != 0) return rankComparison;
        return Suit.CompareTo(other.Suit);
    } 
}
