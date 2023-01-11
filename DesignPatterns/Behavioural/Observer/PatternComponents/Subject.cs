namespace DesignPatterns.Behavioural.Observer.PatternComponents;

public class Subject : CanHaveSubscribers
{
    public Subject(string name) : base(name)
    {
    }
}

public abstract class CanHaveSubscribers : ISubject
{
    private List<IObserver> _observers = new();

    protected CanHaveSubscribers(string name)
    {
        Name = name;
    }

    public string Name { get; }
    
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