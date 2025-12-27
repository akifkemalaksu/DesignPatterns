namespace FacadePattern.Services
{
    public class LogisticService
    {
        public void ShipProduct(string productId, string address)
        {
            Console.WriteLine($"LogisticService: {productId} için {address} adresine gönderiliyor...");
        }
    }
}