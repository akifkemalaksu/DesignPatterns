using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern.Services
{
    public class InventoryService
    {
        public bool IsProductInStock(string productId)
        {
            Console.WriteLine($"InventoryService: {productId} için stok kontrol ediliyor...");
            return true;
        }

        public void DeductProductStock(string productId, int quantity)
        {
            Console.WriteLine($"InventoryService: {productId} için {quantity} adet stok düşürüldü.");
        }
    }
}