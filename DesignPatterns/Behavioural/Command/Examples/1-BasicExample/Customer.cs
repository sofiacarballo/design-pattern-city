namespace DesignPatterns.Behavioural.Command.Examples._1_BasicExample;

public class Customer : IClient
{
    public void PlaceOrder(IInvoker waiter, ICommand command)
    {
        waiter.SetCommand(command);
    }
}