using Shapes.AbstractDomain;
using System;

namespace Shapes.ConcreteDomain
{
    public class Dodecahedron : IShape
    {
        public double SmallArea { get; private set; }
        public Dodecahedron(double smallArea)
        {
            this.SmallArea = smallArea;
        }

        public double Area()
        {
            return 10;
        }

        public override string ToString()
        {
            return $"A = {SmallArea}^2 * 12312512512 => {Area()}";
        }
    }
}
