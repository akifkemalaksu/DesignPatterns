using AdapterPattern.Models;

namespace AdapterPattern.Services
{
    // Adaptee: Bu sınıfın var olan sistemimizin IPaymentService arayüzünden haberi yok.
    // Genellikle 3. parti bir kütüphane veya değiştirilemez eski bir kod bloğudur.
    public class PayTrSDK
    {
        public void MakePayTrPayment(PayTrPayment payTrPayment)
        {
            Console.WriteLine($"PayTr SDK (Adaptee): Ödeme işleniyor... OrderId: {payTrPayment.OrderId}, Tutar: {payTrPayment.Amount}");
        }
    }
}
