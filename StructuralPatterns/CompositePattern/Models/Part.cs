namespace CompositePattern.Models
{
    public abstract class Part
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public abstract decimal GetTotalPrice();
        public abstract string PrintStructure(string indent = "");
    }
}
