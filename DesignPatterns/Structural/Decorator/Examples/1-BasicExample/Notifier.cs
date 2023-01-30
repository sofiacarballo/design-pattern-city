namespace DesignPatterns.Structural.Decorator.Examples._1_BasicExample;

public class Notifier : INotifier
{
    public string Send(string message)
    {
        return $"You got a new notification: {message}";
    } 
}