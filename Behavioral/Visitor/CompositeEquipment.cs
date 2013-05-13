using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
        class CompositeEquipment : IEquipment
        {
                public override int Price 
                {
                        get
                        {
                                int price = 0;
                                foreach (IEquipment e in this.equipment)
                                        price += e.Price;
                                return price;
                        }
                        set
                        {
                                return;
                        }
                }

                public override void Add(IEquipment equipment)
                {
                        this.equipment.Add(equipment);
                }

                public override void Remove(IEquipment equipment)
                {
                        this.equipment.Remove(equipment);
                }

                public override void Run()
                {
                        Console.WriteLine("starting {0} equipment", Name);
                        foreach (IEquipment e in this.equipment)
                                e.Run();
                        Console.WriteLine("{0} equipment is running", Name);
                }

                public override void Accept(IVisitor visitor)
                {
                        foreach (IEquipment equipment in this.equipment)
                                equipment.Accept(visitor);
                        visitor.Visit(this);
                }

                IList<IEquipment> equipment = new List<IEquipment>();
        }
}
