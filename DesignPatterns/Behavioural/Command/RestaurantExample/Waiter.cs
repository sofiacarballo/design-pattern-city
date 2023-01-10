namespace DesignPatterns.Behavioural.Command.RestaurantExample;

public class Waiter : IInvoker
{
    private ICommand _command = new NullCommand();

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
    }
}