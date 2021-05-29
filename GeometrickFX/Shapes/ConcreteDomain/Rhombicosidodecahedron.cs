using Shapes.AbstractDomain;

namespace Shapes.ConcreteDomain
{
    public class Rhombicosidodecahedron : IShape
    {
        private Dodecahedron _decahedron;
        public Rhombicosidodecahedron(Dodecahedron decahedron)
        {
            _decahedron = decahedron;
        }

        public double Area() => _decahedron.Area() * 10;

        public override string ToString()
        {
            return $"A = a^2 * (2135) => {Area()}";
        }
    }
}
