namespace CompositePattern.Models
{
    public class Assembly : Part
    {
        private readonly List<Part> _parts = [];
        public void AddPart(Part part)
        {
            _parts.Add(part);
        }
        public void RemovePart(Part part)
        {
            _parts.Remove(part);
        }
        public override decimal GetTotalPrice()
        {
            return _parts.Sum(part => part.GetTotalPrice()) * Quantity;
        }
        public override string PrintStructure(string indent = "")
        {
            var result = $"{indent}+ Assembly: {Name} (Code: {Code}, Quantity: {Quantity}, Price: {Price:C})\n";
            foreach (var part in _parts)
            {
                result += part.PrintStructure(indent + "  ") + "\n";
            }
            return result.TrimEnd();
        }
    }
}
