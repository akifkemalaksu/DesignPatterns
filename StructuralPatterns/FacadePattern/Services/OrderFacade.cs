using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Services
{
    public class OrderFacade(
        InventoryService inventoryService,
        PaymentService paymentService,
        LogisticService logisticService,
        NotificationService notificationService
    )
    {
        public void PlaceOrder(string productId,decimal amount, string address)
        {
            if (!inventoryService.IsProductInStock(productId))
            {
                notificationService.SendNotification($"Stokta {productId} bulunmamaktadır.");
                return;
            }

            paymentService.ProcessPayment(productId, amount);
            logisticService.ShipProduct(productId, address);
            notificationService.SendNotification($"Sipariş {productId} başarıyla alındı.");
            notificationService.SendNotification($"Sipariş {productId} {address} adresine gönderildi.");
            inventoryService.DeductProductStock(productId);
            notificationService.SendNotification($"Sipariş {productId} stoktan düşüldü.");
        }
    }
}