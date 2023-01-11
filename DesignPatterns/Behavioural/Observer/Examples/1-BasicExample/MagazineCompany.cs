using DesignPatterns.Behavioural.Observer.PatternComponents;

namespace DesignPatterns.Behavioural.Observer.Examples._1_BasicExample;

public class MagazineCompany : ISubject
{
    // This is just an example of how we could actually use the Notify method
    public void PublishNewMagazine()
    {
        Notify();
    }

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