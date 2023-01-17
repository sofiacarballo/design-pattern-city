namespace DesignPatterns.Structural.Adapter.PatternComponents;

// ITarget represents an interface that exists within our domain.
public class Adapter : ITarget 
{
    private readonly ThingToAdapt _thingToAdapt;

    public Adapter(ThingToAdapt thingToAdapt)
    {
        _thingToAdapt = thingToAdapt;
    }

    public string GetRequest()
    {
        /*
         * Within our Adapter class, we can perform whatever actions necessary
         * to make the data / methods of the adaptee usable within our domain.
         */
        return _thingToAdapt.MethodIncompatibleWithDomain();
    }
}