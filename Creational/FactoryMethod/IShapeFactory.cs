using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
        interface IShapeFactory
        {
                IShape CreateCircle();
                IShape CreateSquare();
        }
}
