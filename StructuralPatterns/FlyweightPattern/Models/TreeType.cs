public class TreeType                                                               
{
    public string Name { get; set; }
    public string Color { get; set; }
    public string Texture { get; set; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing {Name} at ({x}, {y}) with color {Color} and texture {Texture}");
    }
}