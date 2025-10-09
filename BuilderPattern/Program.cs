using BuilderPattern;
using BuilderPattern.Builders;
using BuilderPattern.Products;
using System.Text.Json;

CarBuilder carBuilder = new();
ManualBuilder manualBuilder = new();

Director director = new(carBuilder);
director.MakeSUV();
director.SetBuilder(manualBuilder);
director.MakeSportsCar();

Car car = carBuilder.GetResult();
Manual manual = manualBuilder.GetResult();

Console.WriteLine(JsonSerializer.Serialize(car));
Console.WriteLine(JsonSerializer.Serialize(manual));

