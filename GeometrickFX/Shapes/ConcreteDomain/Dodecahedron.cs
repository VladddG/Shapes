using Shapes.AbstractDomain;
using System;

namespace Shapes.ConcreteDomain
{
    public class Dodecahedron : ShapeGlobals, IShape
    {
        public Dodecahedron(float x, float y) : base(x, y)
        {

        }

        public float Area()
        {
            return 10;
        }

        public float[] Localize() => GetPosition();

        public override string ToString()
        {
            return $"A = a^2 * 12312512512 => {Area()}";
        }
    }
}
