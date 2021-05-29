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
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(42.2, x => Math.PI * Math.Pow(x,2)),
                new Dodecahedron(10),
                new Rhombicosidodecahedron(new Dodecahedron(11))
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"area of {shape.GetType().Name} is calculated using this formula: {shape}");
            }

            Console.ReadKey();
        }
    }
}
