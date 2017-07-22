using System.Text;

public class Spy : Soldier,ISpy
{
    public Spy(string id, string firstName, string lastName,int codeNumber) 
        : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public int CodeNumber { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
        sb.AppendLine($"Code Number: {this.CodeNumber}");
        return sb.ToString().Trim();
    }
}
