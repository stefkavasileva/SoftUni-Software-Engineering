using System;

public class RetireCommand : Command
{
    [Inject]
    private readonly IRepository repository;

    public RetireCommand(string[] data)
        : base(data)
    {
    }

    public override string Execute()
    {
        try
        {
            this.repository.RemoveUnit(this.Data[1]);
            return $"{this.Data[1]} retired!";
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
    }
}