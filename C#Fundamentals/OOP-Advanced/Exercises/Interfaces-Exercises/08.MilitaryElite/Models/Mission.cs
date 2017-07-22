public class Mission :IMission
{
    public Mission(string codeName, string state)
    {
       this.CodeName = codeName;
       this.State = state;
    }

    public string CodeName { get; protected set; }
    public string State { get; protected set; }

    public void CompleteMission()
    {
        this.State = "Finished";
    }

    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.State}";
    }
}

