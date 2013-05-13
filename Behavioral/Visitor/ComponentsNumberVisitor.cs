using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
        class ComponentsNumberVisitor : IVisitor
        {
                public int ComponentsNumber { get { return this.componentsNumber; } }

                public void Visit(Card card)
                {
                        this.componentsNumber++;
                }

                public void Visit(Drive drive)
                {
                        this.componentsNumber++;
                }

                public void Visit(Processor processor)
                {
                        this.componentsNumber++;
                }

                public void Visit(CompositeEquipment equipment)
                {
                        // do not count up root nodes
                }

                int componentsNumber = 0;
        }
}
