using DesignPatterns.Behavioural.Observer.PatternComponents;

namespace DesignPatterns.Behavioural.Observer.Examples._2_AdvancedExample;

public abstract class CanHaveSubscribers : ISubject
{
    private readonly List<IObserver> _observers = new();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}