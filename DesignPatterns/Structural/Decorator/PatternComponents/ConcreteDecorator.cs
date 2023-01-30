namespace DesignPatterns.Structural.Decorator.PatternComponents;

public class ConcreteDecorator : BaseDecorator
{
    public ConcreteDecorator(IComponent wrappedComponent) : base(wrappedComponent)
    {
    }

    public override string Execute()
    {
        return _wrappedComponent.Execute();
    }

    public void ExtraBehaviour()
    {
    }
}