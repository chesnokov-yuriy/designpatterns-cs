using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
        class TotalCostVisitor : IVisitor
        {
                public int TotalCost { get { return this.totalCost; } }

                public void Visit(Card card)
                {
                        this.totalCost += card.Price;
                }

                public void Visit(Drive drive)
                {
                        this.totalCost += drive.Price;
                }

                public void Visit(Processor processor)
                {
                        this.totalCost += processor.Price;
                }

                public void Visit(CompositeEquipment equipment)
                {
                        // no need to add up price of composite
                }

                int totalCost = 0;
        }
}
