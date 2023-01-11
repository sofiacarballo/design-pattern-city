namespace Sandbox.Helpers;

public abstract class ExampleRunner
{
    private void Execute()
    {
        PreRun();
        Run();
        PostRun();
    }

    private void PreRun()
    {
        Console.WriteLine("/*****");   
        Console.WriteLine($"{Title} Example Section");
        Console.WriteLine("*****/\n\n");   
    }

    private void PostRun()
    {
        Console.WriteLine("\n\n/*****");   
        Console.WriteLine($"End of {Title} Section");
        Console.WriteLine("*****/\n\n");   
    }

    private string Title => GetType().Name;

    protected abstract void Run();

    public static void RunFor<T>() where T : ExampleRunner, new()
    {
        new T().Execute();
    }
}