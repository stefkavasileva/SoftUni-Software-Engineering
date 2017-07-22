public class AddCollection : Collection, IAddable
{
    public AddCollection() 
        : base()
    {

    }

    public override int Add(string item)
    {
        base.MyCollection.Add(item);
        return base.MyCollection.Count - 1;
    }

    public override string Remove()
    {
        throw new System.NotImplementedException();
    }
}

