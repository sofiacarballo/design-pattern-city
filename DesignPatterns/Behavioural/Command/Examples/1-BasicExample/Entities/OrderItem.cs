namespace DesignPatterns.Behavioural.Command.Examples._1_BasicExample.Entities;

public class OrderItem
{
    public string Name { get; }
    
    public OrderItem(string name)
    {
        Name = name;
    }
}