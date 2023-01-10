// See https://aka.ms/new-console-template for more information

using DesignPatterns.Behavioural.Command.RestaurantExample;
using DesignPatterns.Behavioural.Command.RestaurantExample.Entities;

var hungryCustomer = new Customer();
var busyWaiter = new Waiter();
var busyKitchen = new Kitchen();

var tastyOrder = new OrderCommand(busyKitchen, 
    new OrderItem("Glass of Water"),
    new OrderItem("Omelette"),
    new OrderItem("Chocolate Cake")
);

hungryCustomer.PlaceOrder(busyWaiter, tastyOrder);

busyWaiter.ExecuteCommand();