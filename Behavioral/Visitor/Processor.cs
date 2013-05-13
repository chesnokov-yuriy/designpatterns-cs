using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
        class Processor : IEquipment
        {
                public override int Price { get; set; }

                public override void Add(IEquipment equipment)
                {
                        Console.WriteLine("can not add equipment to {0} processor", Name);
                }

                public override void Remove(IEquipment equipment)
                {
                        Console.WriteLine("can not remove equipment from {0} processor", Name);
                }

                public override void Run()
                {
                        Console.WriteLine("{0} processor is running", Name);
                }

                public override void Accept(IVisitor visitor)
                {
                        visitor.Visit(this);
                }
        }
}
