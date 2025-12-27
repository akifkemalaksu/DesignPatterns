using CompositePattern.Models;

var chassisSteel = new RawMaterial
{
    Code = "RM001",
    Name = "Steel",
    Quantity = 10,
    Price = 50.0m
};

var wheel = new RawMaterial
{
    Code = "RM002",
    Name = "Wheel",
    Quantity = 4,
    Price = 100.0m
};

var engine = new RawMaterial
{
    Code = "RM003",
    Name = "Engine",
    Quantity = 1,
    Price = 5000.0m
};

var chassis = new Assembly
{
    Code = "AS001",
    Name = "Chassis",
    Quantity = 1,
    Price = 2000.0m
};
chassis.AddPart(chassisSteel);

var car = new Assembly
{
    Code = "AS002",
    Name = "Car",
    Quantity = 1,
    Price = 10000.0m
};
car.AddPart(chassis);
car.AddPart(wheel);
car.AddPart(engine);

Console.WriteLine("Car Structure:");
Console.WriteLine(car.PrintStructure());
Console.WriteLine($"Total Price: {car.GetTotalPrice():C}");
Console.ReadLine();