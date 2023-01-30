namespace DesignPatterns.Structural.Decorator.PatternComponents;

public class Component : IComponent
{
    public string Execute()
    {
        return "Basic behaviour that can be altered by decorators";
    }
}