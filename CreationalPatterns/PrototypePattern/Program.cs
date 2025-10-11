using PrototypePattern.Models;

var invoice1 = new Invoice
{
    Title = "Invoice #001",
    Author = "Akif Kemal",
    Amount = 1999.99m
};

var invoice2 = invoice1.Clone();
invoice2.Title = "Invoice #001 Copy";
invoice2.Amount = 2099.99m;

invoice1.Display();
invoice2.Display();