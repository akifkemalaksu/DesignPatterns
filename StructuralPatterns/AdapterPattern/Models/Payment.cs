namespace AdapterPattern.Models
{
    public record Payment
    {
        public required string OrderId { get; set; }
        public string? Description { get; set; }
        public required decimal Amount { get; set; }
    }

    public record PayTrPayment
    {
        public required string OrderId { get; set; }
        public required decimal Amount { get; set; }
    }
}
