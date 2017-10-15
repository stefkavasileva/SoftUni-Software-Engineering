using System.Collections.Generic;

public class InspectCommand : AbstractCommand
{
    public InspectCommand(IList<string> args, IManager managaer) 
        : base(args, managaer)
    {
    }

    public override string Execute()
    {
        return base.Manager.Inspect(this.ArgsList);
    }


}
