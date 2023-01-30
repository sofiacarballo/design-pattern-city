namespace DesignPatterns.Structural.Decorator.Examples._1_BasicExample;

public class Notifier : INotifier
{
    public string Send(string message)
    {
        return $"Notifier: {message}";
    } 
}