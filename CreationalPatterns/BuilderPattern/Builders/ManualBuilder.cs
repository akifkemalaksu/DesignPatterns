using BuilderPattern.Interfaces;
using BuilderPattern.Parts;
using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
    public class ManualBuilder : IBuilder
    {
        private Manual manual = new Manual();
        public void Reset()
        {
            manual = new Manual();
        }

        public void SetEngine(IEngine engine)
        {
            manual.Engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }

        public void SetGPS()
        {
            manual.HasGPS = true;
        }

        public void SetSeats(int seatCount)
        {
            manual.SeatCount = seatCount;
        }

        public void SetTripComputer()
        {
            manual.HasTripComputer = true;
        }

        public Manual GetResult()
        {
            Manual result = manual;
            Reset();
            return result;
        }
    }
}