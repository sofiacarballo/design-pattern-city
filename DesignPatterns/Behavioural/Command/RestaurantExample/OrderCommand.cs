using DesignPatterns.Behavioural.Command.RestaurantExample.Entities;

namespace DesignPatterns.Behavioural.Command.RestaurantExample;

public class OrderCommand : ICommand
{
    private Kitchen _kitchen;
    private OrderItem[] _orderItems;
    
    public OrderCommand(Kitchen kitchen, params OrderItem[] orderItems)
    {
        _kitchen = kitchen;
        _orderItems = orderItems;
    }
    
    public void Execute()
    {
        Kitchen.PrepareFoodItems(_orderItems);
    }
}