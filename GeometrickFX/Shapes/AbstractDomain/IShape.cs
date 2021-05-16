using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.AbstractDomain
{
    public interface IShape
    {
        float Area();
        float[] Localize();
    }
}
