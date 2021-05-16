using Shapes.AbstractDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ConcreteDomain
{
    public class Circle : ShapeGlobals, IShape
    {
        private double _radius;
        readonly Expression<Func<float, float>> _formula;
        public Circle(double radius, Expression<Func<float, float>> formula, float x, float y) : base(x, y)
        {
            _radius = radius;
            _formula = formula;
        }
        public float Area()
        {
            Func<float, float> result = _formula.Compile();
            return result((float) _radius);
        }

        public float[] Localize() => GetPosition();

        public override string ToString()
        {
            return $"A = pi*r^2 => {Area()} ";
        }
    }
}
