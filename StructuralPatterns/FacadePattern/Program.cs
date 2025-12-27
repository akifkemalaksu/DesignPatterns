using FacadePattern.Services;

var orderFacade = new OrderFacade(
    new InventoryService(),
    new PaymentService(),
    new LogisticService(),
    new NotificationService()
);

orderFacade.PlaceOrder("12345", 99.99m, "123 Main St");