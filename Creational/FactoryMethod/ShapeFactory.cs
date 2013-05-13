using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
        class ShapeFactory : IShapeFactory
        {
                public IShape CreateCircle()
                {
                        return new Circle();
                }

                public IShape CreateSquare()
                {
                        return new Square();
                }
        }
}
