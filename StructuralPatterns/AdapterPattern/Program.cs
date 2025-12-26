using AdapterPattern.Services;

IPaymentService paymentService = new PayTrPaymentService();

var payment = new AdapterPattern.Models.Payment
{
    OrderId = "12345",
    Description = "Sample Payment",
    Amount = 99.99m
};

paymentService.ProcessPayment(payment);