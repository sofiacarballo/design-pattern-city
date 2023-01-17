namespace DesignPatterns.Structural.Adapter;

public class ThingToAdapt
{
    public string MethodIncompatibleWithDomain()
    {
        return "This method can't immediately be used by our domain.";
    }
}