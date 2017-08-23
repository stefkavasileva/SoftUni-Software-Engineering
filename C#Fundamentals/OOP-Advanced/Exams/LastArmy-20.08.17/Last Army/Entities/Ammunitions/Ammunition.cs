public abstract class Ammunition : IAmmunition
{
    //remove wearLevel posible bug
    protected Ammunition()
    {
         
        //this.WearLevel = weight * 100;
    }

    public string Name { get; protected set; }
    public double Weight { get; protected set; }
    public double WearLevel { get; protected set; }

    //след всяка успешна мисия се увеличава левела
    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel += wearAmount;
    }
}

