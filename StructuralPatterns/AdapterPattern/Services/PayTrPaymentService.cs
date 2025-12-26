using AdapterPattern.Models;

namespace AdapterPattern.Services
{
    public class PayTrPaymentService : IPaymentService
    {
        public void ProcessPayment(Payment payment)
        {
            var payTrPayment = new PayTrPayment
            {
                OrderId = payment.OrderId,
                Amount = payment.Amount
            };

            ProcessPayTrPayment(payTrPayment);
        }

        private void ProcessPayTrPayment(PayTrPayment payTrPayment)
        {
            Console.WriteLine($"Processing PayTr payment for OrderId: {payTrPayment.OrderId}, Amount: {payTrPayment.Amount}");
        }
    }
}
