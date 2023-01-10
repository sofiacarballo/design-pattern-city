using DesignPatterns.Behavioural.Command.RestaurantExample.Entities;

namespace DesignPatterns.Behavioural.Command.RestaurantExample;

// This would be the Receiver.
public class Kitchen
{
    private static void PrepareFoodItem(OrderItem orderItem)
    {
        Console.Out.WriteLine($"Prepared {orderItem.Name}");
    }

    public static void PrepareFoodItems(IEnumerable<OrderItem> orderItems)
    {
        foreach (var orderItem in orderItems)
        {
            PrepareFoodItem(orderItem);
        }
    }
}