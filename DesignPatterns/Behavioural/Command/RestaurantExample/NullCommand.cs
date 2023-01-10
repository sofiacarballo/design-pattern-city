namespace DesignPatterns.Behavioural.Command.RestaurantExample;

public class NullCommand : ICommand
{
    public void Execute()
    {
        // Null command does nothing
    }
}