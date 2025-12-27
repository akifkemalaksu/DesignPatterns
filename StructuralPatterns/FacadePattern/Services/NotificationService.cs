namespace FacadePattern.Services
{
    public class NotificationService
    {
        public void SendNotification(string productId, string address)
        {
            Console.WriteLine($"NotificationService: {productId} için {address} adresine bildirim gönderiliyor...");
        }
    }
}