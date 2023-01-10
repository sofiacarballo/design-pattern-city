namespace DesignPatterns.Behavioural.Command;

public interface IInvoker
{
    public void SetCommand(ICommand command);
    public void ExecuteCommand();
}