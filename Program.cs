using Microsoft.Extensions.DependencyInjection;
using System;

namespace SolidPrinciplesExample
{
    public class Program
    {
        private static IOrderProcessor _orderProcessor;

        static void Main(string[] args)
        {
            // Setup DI container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IOrderProcessor, OrderProcessor>()
                .AddSingleton<IPaymentProcessor, PaymentProcessor>()
                /*AddSingleton<INotifier, EmailNotifier>()*/ // Change to SmsNotifier to use SMS notifications
                .AddSingleton<INotifier, SmsNotifier>()

                .BuildServiceProvider();

            _orderProcessor = serviceProvider.GetService<IOrderProcessor>();

            // Create an order and process it
            var order = new Order { OrderId = 1, Amount = 100.0 };
            _orderProcessor.ProcessOrder(order);
        }
    }
}

public class Order
{
    public int OrderId { get; set; }
    public double Amount { get; set; }
}
