using DesignPatterns.Behavioural.Observer.PatternComponents;

namespace DesignPatterns.Behavioural.Observer.Examples._1_BasicExample;

public class Subscriber : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine($"Hey, I just got told that a new magazine has come out!");
    }
}