namespace DesignPatterns.Behavioural.Command.Examples._1_BasicExample;

public class NullCommand : ICommand
{
    public void Execute()
    {
        // Null command does nothing
    }
}