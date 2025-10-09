using BuilderPattern.Interfaces;
using BuilderPattern.Parts;

namespace BuilderPattern
{
    public class Director
    {
        public void MakeSUV(IBuilder builder)
        {
            builder.SetSeats(5);
            builder.SetEngine(new SUVEngine());
            builder.SetGPS();
            builder.SetTripComputer();
        }

        public void MakeSportsCar(IBuilder builder)
        {
            builder.SetSeats(2);
            builder.SetEngine(new SportEngine());
        }
    }
}