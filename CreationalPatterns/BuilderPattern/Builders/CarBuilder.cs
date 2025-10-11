using BuilderPattern.Interfaces;
using BuilderPattern.Parts;
using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
    public class CarBuilder : IBuilder
    {
        private Car car = new Car();
        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine(IEngine engine)
        {
            car.Engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }

        public void SetGPS()
        {
            car.HasGPS = true;
        }

        public void SetSeats(int seatCount)
        {
            car.SeatCount = seatCount;
        }

        public void SetTripComputer()
        {
            car.HasTripComputer = true;
        }

        public Car GetResult()
        {
            Car result = car;
            Reset();
            return result;
        }
    }
}