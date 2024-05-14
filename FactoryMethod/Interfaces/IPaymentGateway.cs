
namespace FactoryMethod.Interfaces
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
