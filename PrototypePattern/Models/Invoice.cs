namespace PrototypePattern.Models
{
    public class Invoice : Document
    {
        public decimal Amount { get; set; }

        public Invoice() { }

        public Invoice(Invoice source) : base(source)
        {
            if (source != null)
                Amount = source.Amount;
        }

        public override Invoice Clone()
        {
            return new Invoice(this);
        }

        public override void Display()
        {
            Console.WriteLine($"Invoice - Title: {Title}, Amount: {Amount:C}, Author: {Author}");
        }
    }
}
