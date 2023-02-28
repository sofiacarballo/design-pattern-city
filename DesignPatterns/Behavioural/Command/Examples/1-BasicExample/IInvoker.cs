namespace DesignPatterns.Behavioural.Command.Examples._1_BasicExample;

public interface IInvoker
{
    public void SetCommand(ICommand command);
    public void ExecuteCommand();
}