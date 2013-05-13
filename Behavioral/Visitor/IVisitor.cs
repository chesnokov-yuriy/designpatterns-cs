using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
        interface IVisitor
        {
                void Visit(Card card);
                void Visit(Drive drive);
                void Visit(Processor processor);
                void Visit(CompositeEquipment equipment);
        }
}
