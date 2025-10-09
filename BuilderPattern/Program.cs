using BuilderPattern;
using BuilderPattern.Builders;
using BuilderPattern.Products;
using System.Text.Json;

Director director = new();

CarBuilder carBuilder = new();
ManualBuilder manualBuilder = new();

director.MakeSUV(carBuilder);
director.MakeSUV(manualBuilder);

Car car = carBuilder.GetResult();
Manual manual = manualBuilder.GetResult();

Console.WriteLine(JsonSerializer.Serialize(car));
Console.WriteLine(JsonSerializer.Serialize(manual));

