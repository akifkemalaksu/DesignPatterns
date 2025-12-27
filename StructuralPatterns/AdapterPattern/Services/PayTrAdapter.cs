using AdapterPattern.Models;

namespace AdapterPattern.Services
{
    // Adapter: Adaptee (PayTrSDK) ile Target (IPaymentService) arasındaki köprüyü kurar.
    public class PayTrAdapter : IPaymentService
    {
        private readonly PayTrSDK _payTrSDK;

        public PayTrAdapter()
        {
            _payTrSDK = new PayTrSDK();
        }

        public void ProcessPayment(Payment payment)
        {
            // Gelen veriyi Adaptee'nin anlayacağı formata çeviriyoruz (Mapping)
            var payTrPayment = new PayTrPayment
            {
                OrderId = payment.OrderId,
                Amount = payment.Amount
            };

            // İşlemi Adaptee'ye devrediyoruz
            _payTrSDK.MakePayTrPayment(payTrPayment);
        }
    }
}
