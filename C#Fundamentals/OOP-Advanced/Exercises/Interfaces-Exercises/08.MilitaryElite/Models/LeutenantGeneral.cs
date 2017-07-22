using System;
using System.Collections.Generic;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary) 
        : base(id, firstName, lastName, salary)
    {
        this.Privates = new List<IPrivate>();
    }

    public IList<IPrivate> Privates { get; }

    public override string ToString()
    {
        return
            $"{base.ToString()}{Environment.NewLine}Privates:{Environment.NewLine+ "  "}{string.Join(Environment.NewLine + "  ", this.Privates)}";
    }
}