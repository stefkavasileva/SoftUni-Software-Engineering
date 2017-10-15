using System.Collections.Generic;

public abstract class AbstractCommand : ICommand
{
    private IList<string> args;
    private IManager manager;

    protected AbstractCommand(IList<string> args ,IManager managaer)
    {
        this.ArgsList = args;
        this.Manager = managaer;
    }

    public IList<string> ArgsList
    {
        get => this.args;
        protected set => this.args = value;
    }

    public IManager Manager
    {
        get => this.manager;
        protected set => this.manager = value;
    }

    public abstract string Execute();
}

