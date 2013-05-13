using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
        class Drive : IEquipment
        {
                public override int Price { get; set; }

                public override void Add(IEquipment equipment)
                {
                        Console.WriteLine("can not add equipment to {0} drive", Name);
                }

                public override void Remove(IEquipment equipment)
                {
                        Console.WriteLine("can not remove equipment from {0} drive", Name);
                }

                public override void Run()
                {
                        Console.WriteLine("{0} drive is running", Name);
                }
        }
}
