namespace DesignPatterns.Behavioural.Command.RestaurantExample.Entities;

public class OrderItem
{
    public string Name { get; }
    
    public OrderItem(string name)
    {
        Name = name;
    }
}