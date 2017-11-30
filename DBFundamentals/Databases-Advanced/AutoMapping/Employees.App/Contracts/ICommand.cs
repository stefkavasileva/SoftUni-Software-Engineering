namespace Employees.App.Contracts
{
    public interface ICommand
    {
        string Execute(params string[] data);
    }
}
