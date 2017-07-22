public class MyList : Collection, IAddable, IRemoveble, IUseble
{
    public int Used => base.MyCollection.Count;

    public override string Remove()
    {
        var lastItem = base.MyCollection[0];
        base.MyCollection.RemoveAt(0);
        return lastItem;
    }

    public override int Add(string item)
    {
        base.MyCollection.Insert(0, item);
        return 0;
    }
}

