public interface IMission
{
    string CodeName { get; }

    string State { get; }

    void CompleteMission();
}