namespace SOLID_code_examples.DIP.Failing
{
    public interface IMessagingService
    {
        void SendMessage(ICustomer customer, string message);
    }
}