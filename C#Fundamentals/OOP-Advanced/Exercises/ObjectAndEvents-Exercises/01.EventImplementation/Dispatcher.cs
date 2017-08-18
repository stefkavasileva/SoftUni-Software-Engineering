public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);

public class Dispatcher
{
    private string name;

    public event NameChangeEventHandler NameChange;

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
            this.OnNameChange(new NameChangeEventArgs(value));
        }
    }

    protected virtual void OnNameChange(NameChangeEventArgs args)
    {
        if (this.NameChange != null)
        {
            this.NameChange(this, args);
        }
    }
}