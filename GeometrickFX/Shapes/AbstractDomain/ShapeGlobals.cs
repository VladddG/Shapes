using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.AbstractDomain
{
    public abstract class ShapeGlobals
    {
        float _x;
        float _y;

        public ShapeGlobals(float x, float y)
        {
            _x = x;
            _y = y;
        }

        protected float[] GetPosition() => new float[] { _x, _y };
    }
}
