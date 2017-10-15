using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class AbstractHero : IHero, IComparable<AbstractHero>
{
    private IInventory inventory;
    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    protected AbstractHero(string name, int strength, int agility, int intelligence, int hitPoints, int damage)
    {
        this.Name = name;
        this.strength = strength;
        this.agility = agility;
        this.intelligence = intelligence;
        this.hitPoints = hitPoints;
        this.damage = damage;
        this.inventory = new HeroInventory();
    }

    public string Name { get; protected set; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        protected set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        protected set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
       protected  set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
       protected set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
       protected set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    //REFLECTION
    public ICollection<IItem> Items
    {
        get
        {
            var classType = typeof(HeroInventory); 
            var field = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => f.GetCustomAttributes(typeof(ItemAttribute), false) != null);

            var collection =  (Dictionary<string, IItem>)field.GetValue(this.inventory);

            return collection.Values.ToList();
        }
    }

    public void AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
    }

    public void AddItem(IItem item)
    {
        this.Items.Add(item);
    }

    public int CompareTo(AbstractHero other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var primary = this.PrimaryStats.CompareTo(other.PrimaryStats);
        if (primary != 0)
        {
            return primary;
        }
        return this.SecondaryStats.CompareTo(other.SecondaryStats);
    }
}