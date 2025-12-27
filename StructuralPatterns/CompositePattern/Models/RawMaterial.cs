namespace CompositePattern.Models
{
    public class RawMaterial : Part
    {
        public override decimal GetTotalPrice()
        {
            return Price * Quantity;
        }
        public override string PrintStructure(string indent = "")
        {
            return $"{indent}- Raw Material: {Name} (Code: {Code}, Quantity: {Quantity}, Price: {Price:C})";
        }
    }
}
