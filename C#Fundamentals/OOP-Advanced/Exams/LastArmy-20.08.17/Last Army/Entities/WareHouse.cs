using System.Collections;
using System.Collections.Generic;

public class WareHouse : IWareHouse
{
    private IList<IAmmunition> weapons;

    public WareHouse()
    {
       
        this.Weapons = new List<IAmmunition>();
    }

    public string Name { get; private set; }
    public int Count { get; private set; }

    //Добавено от мен, би трябвало да може тук да се добавят уепъните 
    public IList<IAmmunition> Weapons
    {
        get => this.weapons;
        protected set => this.weapons = value;
    }

    public void AddAmmunitions(string ammunitionType, int count)
    {
        throw new System.NotImplementedException();
    }

    public void EquipArmy(IArmy army)
    {
        throw new System.NotImplementedException();
    }
}

