using Shapes.AbstractDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ConcreteDomain
{
    public class Rhombicosidodecahedron : ShapeGlobals, IShape
    {
        private Dodecahedron _decahedron;
        public Rhombicosidodecahedron(Dodecahedron decahedron, float x, float y) : base(x, y)
        {
            _decahedron = decahedron;
        }

        public float Area() => _decahedron.Area() * 10;

        public float[] Localize() => GetPosition();

        public override string ToString()
        {
            return $"A = a^2 * (2135) => {Area()}";
        }
    }
}
