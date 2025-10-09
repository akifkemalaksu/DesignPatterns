using BuilderPattern.Interfaces;
using BuilderPattern.Parts;

namespace BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder ?? throw new ArgumentNullException(nameof(builder));
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder ?? throw new ArgumentNullException(nameof(builder));
        }

        public void MakeSUV()
        {
            _builder.Reset();
            _builder.SetSeats(5);
            _builder.SetEngine(new SUVEngine());
            _builder.SetGPS();
            _builder.SetTripComputer();
        }

        public void MakeSportsCar()
        {
            _builder.Reset();
            _builder.SetSeats(2);
            _builder.SetEngine(new SportEngine());
        }
    }
}