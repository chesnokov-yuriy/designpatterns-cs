using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
        class Program
        {
                static void Main(string[] args)
                {
                        IShapeFactory shapeFactory = new ShapeFactory();
                        IShape circle = shapeFactory.CreateCircle();
                        IShape square = shapeFactory.CreateSquare();
                }
        }
}
