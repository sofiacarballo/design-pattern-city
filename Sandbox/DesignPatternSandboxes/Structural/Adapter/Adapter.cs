using DesignPatterns.Structural.Adapter.Examples._1_BasicExample;
using Sandbox.Helpers;

namespace Sandbox.DesignPatternSandboxes.Structural.Adapter;

public class Adapter : ExampleRunner
{
    protected override void Run()
    {
        var englishWordGenerator = new EnglishWordGenerator();
        var spanishWordGenerator = new EnglishToSpanishAdapter(englishWordGenerator);

        Console.WriteLine(spanishWordGenerator.GenerateSpanishWord());
    }
}