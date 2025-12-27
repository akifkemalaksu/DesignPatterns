namespace FacadePattern.Services
{
    public class PaymentService
    {
        public void ProcessPayment(string cardDetails, decimal amount)
        {
            Console.WriteLine($"PaymentService: {cardDetails} ile {amount} tutarında ödeme işlemi yapılıyor...");
        }
    }
}