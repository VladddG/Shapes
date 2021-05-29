using Shapes.AbstractDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ConcreteDomain
{
    public class Circle : IShape
    {
        private double _radius;
        readonly Expression<Func<double, double>> _formula;
        public Circle(double radius, Expression<Func<double, double>> formula)
        {
            _radius = radius;
            _formula = formula;
        }
        public double Area()
        {
            Func<double, double> result = _formula.Compile();
            return result(_radius);
        }

        public override string ToString()
        {
            return $"A = pi*r^2 => {Area()} ";
        }
    }
}
