using DesignPatterns.Creational.Builder._1_BasicExample;
using Sandbox.Helpers;

namespace Sandbox.DesignPatternSandboxes.Creational.Builder;

public class Builder : ExampleRunner
{
    protected override void Run()
    {
        CarBuilder carBuilder = new CarBuilder();
        carBuilder
            .SetEngine(Engine.Electrical)
            .SetSeats(4)
            .Build();
    }
}