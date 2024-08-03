namespace SolidPrinciplesExample
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Order order);
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment(Order order);
    }

    public interface INotifier
    {
        void NotifyCustomer(Order order);
    }
}
