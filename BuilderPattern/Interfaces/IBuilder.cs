using System.Dynamic;
using BuilderPattern.Parts;

namespace BuilderPattern.Interfaces
{
    public interface IBuilder
    {
        void Reset();

        void SetSeats(int seatCount);

        void SetEngine(IEngine engine);

        void SetTripComputer();

        void SetGPS();
    }
}