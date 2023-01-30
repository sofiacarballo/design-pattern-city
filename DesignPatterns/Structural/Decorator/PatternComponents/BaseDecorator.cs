namespace DesignPatterns.Structural.Decorator.PatternComponents;

public abstract class BaseDecorator : IComponent
{
    public IComponent _wrappedComponent;

    public BaseDecorator(IComponent wrappedComponent)
    {
        _wrappedComponent = wrappedComponent;
    }

    public abstract string Execute();
}