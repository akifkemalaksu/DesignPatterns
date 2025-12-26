using AdapterPattern.Models;

namespace AdapterPattern.Services
{
    public interface IPaymentService
    {
        void ProcessPayment(Payment payment);
    }
}
