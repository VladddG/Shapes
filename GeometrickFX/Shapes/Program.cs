using Shapes.AbstractDomain;
using Shapes.ConcreteDomain;
using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dodecahedron decahedron = new Dodecahedron((float)5.5452, (float)1.2);
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(42.2, x => Convert.ToSingle( Math.PI * Math.Pow(x,2)), (float)44.2, (float) 78),
                decahedron,
                new Rhombicosidodecahedron(decahedron, (float) 29.42552, (float) 52.125125)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"area of {shape.GetType().Name} is calculated using this formula: {shape}");
            }

            Console.ReadKey();
        }
    }
}
