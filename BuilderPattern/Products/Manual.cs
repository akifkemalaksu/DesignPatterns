using BuilderPattern.Parts;

namespace BuilderPattern.Products
{
    public class Manual
    {
        public int SeatCount { get; set; }

        public IEngine Engine { get; set; }

        public bool HasTripComputer { get; set; }

        public bool HasGPS { get; set; }
    }
}