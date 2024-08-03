using System;

namespace SolidPrinciplesExample
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly INotifier _notifier;

        public OrderProcessor(IPaymentProcessor paymentProcessor, INotifier notifier)
        {
            _paymentProcessor = paymentProcessor;
            _notifier = notifier;
        }

        public void ProcessOrder(Order order)
        {
            _paymentProcessor.ProcessPayment(order);
            _notifier.NotifyCustomer(order);
        }
    }

    public class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            // Process payment logic
            Console.WriteLine($"Payment for Order {order.OrderId} processed. Amount: {order.Amount}");
        }
    }

    public class EmailNotifier : INotifier
    {
        public void NotifyCustomer(Order order)
        {
            // Send email notification logic
            Console.WriteLine($"Email notification sent for Order {order.OrderId}.");
        }
    }

    public class SmsNotifier : INotifier
    {
        public void NotifyCustomer(Order order)
        {
            // Send SMS notification logic
            Console.WriteLine($"SMS notification sent for Order {order.OrderId}.");
        }
    }
}
