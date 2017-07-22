using System.Collections.Generic;

public abstract class Collection : IAddable
{
    protected Collection()
    {
        this.MyCollection = new List<string>();
    }


    private IList<string> myCollection;

    public IList<string> MyCollection
    {
        get => this.myCollection;
        protected set => this.myCollection = value;
    }

    public  abstract int Add(string item);
    public abstract string Remove();

}
