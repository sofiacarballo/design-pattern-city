namespace DesignPatterns.Structural.Decorator;

public class Notifier : INotifier
{
    public string Send(string message)
    {
        return $"Notifier: {message}";
    } 
}