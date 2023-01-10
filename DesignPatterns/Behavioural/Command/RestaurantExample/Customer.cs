namespace DesignPatterns.Behavioural.Command.RestaurantExample;

public class Customer : IClient
{
    public void PlaceOrder(IInvoker waiter, ICommand command)
    {
        waiter.SetCommand(command);
    }
}